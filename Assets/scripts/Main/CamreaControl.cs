using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamreaControl : MonoBehaviour {

    public static CamreaControl _instance;
    public static CamreaControl Instance
    {
        get
        {
            return _instance;
        }
    }
    public float RspeedX;
    public int minAngle;
    public int maxAngle;
    float x;
    float y;
    public Transform[] target;
    private Vector3 direction;
    public int camHeight;
    public  int distance;

    [HideInInspector]
    public int SelectState=0;  //选择的状态数字

    private void Awake()
    {
        _instance = this;
    }
    void Update () {
        CameraRotate();
	}

    void CameraRotate()
    {
        int index=0;
        index = SelectState; //根据状态切换index

       
            if (index == 0 && Input.GetMouseButton(0))
            {
                //解释面板不显示
                distance = 15;

                x += Input.GetAxis("Mouse X") * RspeedX;
                y -= Input.GetAxis("Mouse Y") * RspeedX;

                y = ClampAngle(y, minAngle, maxAngle);


                Quaternion rotateAngle = Quaternion.Euler(y, x, 0);//摄像机偏转角度  

                direction = new Vector3(0, camHeight, -distance);//摄像机距离物品的距离  
                transform.rotation = rotateAngle;//让摄像机始终转向物品  
                transform.position = target[index].position + rotateAngle * direction;//计算旋转多少角度摄像机需要偏移多少  
                transform.LookAt(target[index]);

                y = ClampAngle(y, minAngle, maxAngle);
            }
        
            if (index != 0)
            {
                distance = 3;
                //if (index>=5)//改变距离
                //{
                //    distance = 3;
                //}
                if (Input.GetMouseButton(0))
                {
                    x += Input.GetAxis("Mouse X") * RspeedX;
                }

                //y -= Input.GetAxis("Mouse Y") * RspeedX;

                //y = ClampAngle(y, minAngle, maxAngle);


                Quaternion rotateAngle = Quaternion.Euler(0, x, 0);//摄像机偏转角度  

                direction = new Vector3(0, camHeight, -distance);//摄像机距离物品的距离  
                transform.rotation = rotateAngle;//让摄像机始终转向物品  
                transform.position = target[index].position + rotateAngle * direction;//计算旋转多少角度摄像机需要偏移多少  
                transform.LookAt(target[index]);

                //y = ClampAngle(y, minAngle, maxAngle);
            }
        
    }

    static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }
}
