using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnMarsClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 4;
        msgText.text = "火星代表战神，闪著火色的光芒，体积约为地球的十分之一，火星最高温度达27℃，最低温度至-133℃。火星上最大的火山---奥林柏斯山是太阳系最高的山。";
    }
}
