using System.Collections;
using UnityEngine;
using Vuforia;
using System.Collections.Generic;

public class SimpleUDTHandler : MonoBehaviour, IUserDefinedTargetEventHandler
{
    private UserDefinedTargetBuildingBehaviour mTargetBuildingBehaviour;
    private ObjectTracker mObjectTracker;
    private DataSet mBuiltDataSet;
    public GameObject btnTarget;

    private bool mUdtInitialized = false;
    //这部分定义的是照相机拍摄下来图片的品质，也就是说在图片拍摄下来之后通过这个方法会返回一个枚举类型的参数
    //通过这个参数判断这张图片识别的品质是否可以使用；
    private ImageTargetBuilder.FrameQuality mFrameQuality = ImageTargetBuilder.FrameQuality.FRAME_QUALITY_NONE;

    public ImageTargetBehaviour ImageTargetTemplate;

    void Start()
    {
        mTargetBuildingBehaviour = GetComponent<UserDefinedTargetBuildingBehaviour>();
        if (mTargetBuildingBehaviour)
        {
            mTargetBuildingBehaviour.RegisterEventHandler(this);
        }
    }
    //IUserDefinedTargetEventHandler接口中OnInitialized方法的实现；
    //这个方法是用来进行初始化使用的；
    public void OnInitialized()
    {
        //这里用来实例化mObjectTracker里面的信息
        mObjectTracker = TrackerManager.Instance.GetTracker<ObjectTracker>();

        if (mObjectTracker != null)
        {
            //创建一个新的数据集，放在本地用来存放用户拍摄的ImageTarget
            mBuiltDataSet = mObjectTracker.CreateDataSet();
            //将数据集的状态变为激活状态；（数据集仅在没有跟踪图片的方法没有运行的时候才是激活状态）
            mObjectTracker.ActivateDataSet(mBuiltDataSet);
            //记录组件已经被初始化了
            mUdtInitialized = true;
        }
    }
    //IUserDefinedTargetEventHandler接口中OnFrameQualityChanged方法的实现；
    //这里需要注意：这个方法只是用来接收摄像头扫描的图片品质，具体判断方法是内部封装
    //ImageTargetBuilder.FrameQuality frameQuality 也就是图片的品质
    /*具体的方法是这样一个抽象类，内部识别的方法我们是看不到的；
    public abstract class ImageTargetBuilder
    {
        protected ImageTargetBuilder();
        public abstract bool Build(string targetName, float sceenSizeWidth);
        public abstract FrameQuality GetFrameQuality();
        public abstract TrackableSource GetTrackableSource();
        public abstract void StartScan();
        public abstract void StopScan();
        public enum FrameQuality
        {
            FRAME_QUALITY_NONE = -1,
            FRAME_QUALITY_LOW = 0,
            FRAME_QUALITY_MEDIUM = 1,
            FRAME_QUALITY_HIGH = 2
        }
    }
    */
    public void OnFrameQualityChanged(ImageTargetBuilder.FrameQuality frameQuality)
    {
        //将获取到的图片的品质传给mFrameQuality
        mFrameQuality = frameQuality;
    }
    //IUserDefinedTargetEventHandler接口中OnNewTrackableSource方法的实现；
    //这个方法是在初始化出现错误的时候才会被访问；
    public void OnNewTrackableSource(TrackableSource trackableSource)
    {
        //首先关闭数据集；
        mObjectTracker.DeactivateDataSet(mBuiltDataSet);
        //下面这部分的作用是当数据集饱和也就是满了的时候，就会删除最开始创建的ImageTarget以此类推；
        if (mBuiltDataSet.HasReachedTrackableLimit())
        {
            //此部分是用来加载出数据集中全部的ImageTarget对象；
            IEnumerable<Trackable> trackables = mBuiltDataSet.GetTrackables();
            Trackable oldest = null;
            foreach (Trackable trackable in trackables)
                if (oldest == null || trackable.ID < oldest.ID)
                    oldest = trackable;

            if (oldest != null)
            {
                mBuiltDataSet.Destroy(oldest, true);
            }
        }

        //获取到已经追踪到的Tarckable也就是用户拍摄的ImageTarget并且实例他就可以了；
        ImageTargetBehaviour imageTargetCopy = (ImageTargetBehaviour)Instantiate(ImageTargetTemplate);
        //将是实例过的ImageTarget添加到相应数据集当中；
        mBuiltDataSet.CreateTrackable(trackableSource, imageTargetCopy.gameObject);
        //将数据集设置为激活的状态；
        mObjectTracker.ActivateDataSet(mBuiltDataSet);
    }
    //具体的方法咱们调用完成了之后，下面就来编写UI界面的部分啦，咱们就用OnGUI来简单的实现吧；
    bool IsFirst = true;
    void OnGUI()
    {
        //判断是否进行了初始化 ，如果没有则返回不再执行接下来的程序；
        if (!mUdtInitialized) return;
        //下面我们来根据画面的画质来显示相应的界面，如果用户拍摄的图片的品质在中 高状态下我们就拍摄按键显示出来
        if (mFrameQuality == ImageTargetBuilder.FrameQuality.FRAME_QUALITY_HIGH ||
            mFrameQuality == ImageTargetBuilder.FrameQuality.FRAME_QUALITY_MEDIUM)
        {         
            if(IsFirst)
                btnTarget.SetActive(true);
        }
    }
    //创建ImageTarget按钮；
    private void BuildNewTarget()
    {
        //在这里我们可以自己定义ImageTarget名字；
        string newTargetName = "MyUserDefinedTarget";
        //调用创建的方法；
        mTargetBuildingBehaviour.BuildNewTarget(newTargetName, ImageTargetTemplate.GetSize().x);    
    }
    public void TargetButtonClick()
    {
        btnTarget.SetActive(false);
        IsFirst = false;
        BuildNewTarget();
    }
}
