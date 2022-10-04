using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnJupiterClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 5;
        msgText.text = "木星是整个太阳系最大的行星，亮度仅次于金星，直径有地球的11倍，质量是其他八个行星总和的2.5倍。木星有一个薄、暗的主环，己知有66个卫星。";
    }
}
