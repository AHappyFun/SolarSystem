using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleControl : MonoBehaviour {

    public Text title;
    public Text content;
	void Start () {
		
	}
	
	void Update ()
    {
        switch (jindu.index)
        {
            case 1:
                title.text = "北斗一，天枢";
                content.text = "天枢是一颗K0III型橙色巨星，是颗目视双星，有一颗亮度为4.8等的伴星，双星轨道周期为44.4年角距为0”36。主星拥有4倍太阳质量，32倍太阳半径，是一个巨大的恒星。";
                break;
            case 2:
                title.text = "北斗二，天璇";
                content.text = "作为北斗七星的一员，天璇在北半球更为人熟知。天璇与天枢（大熊座α）相邻，两星连线延长线指向北极星。它也是大北斗星群中五颗大熊座移动星群中的一颗。";
                break;
            case 3:
                title.text = "北斗三，天玑";
                content.text = "天玑，大熊座γ星，别称禄存星，天文专名Phecda，国际通用名 γUma视星等2.50等，距地球83.7±1.4 光年，是北斗七星之一。 ";
                break;
            case 4:
                title.text = "北斗四，天权";
                content.text = "天权，是北斗七星之一，位于斗柄与斗勺连接处，是斗勺的第一颗星，也是北斗七星中最黯淡的一颗，视星等3.40等。";
                break;
            case 5:
                title.text = "北斗五，玉衡";
                content.text = "北斗七星之一，又名北斗五（大熊座ε星），位于斗柄与斗勺连接处，即斗柄的第一颗星。";
                break;
            case 6:
                title.text = "北斗六，开阳";
                content.text = "从勺柄数起第二颗，就是大熊座ζ星，中国古代称为开阳星。仔细看看它，会发现它旁边很近的地方还有一颗暗星，这颗暗星叫大熊座80号星。";
                break;
            case 7:
                title.text = "北斗七，瑶光";
                content.text = "瑶光，古代中国神话和天文学结合的产物。北斗七星的第七星名。古代以为象征祥瑞。";
                break;
            default:
                break;
        }
    }
}
