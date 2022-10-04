using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnNeptnueClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 8;
        msgText.text = "海王星是离太阳最远的行星，有八颗卫星，亦有如土星的环，比天王星更细小、非常暗淡， 崔顿是海王星最大的卫星，也是太阳系中，最冷的星体，温度在摄氏零下235度。";
    }
}
