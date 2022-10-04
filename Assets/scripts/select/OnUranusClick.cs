using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnUranusClick : MonoBehaviour {
    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        msgText.text = "天王星也有如土星一样美丽的环，大约为土星环三分之一宽，是用肉眼所能看到的最远的一颗行星，几乎是横躺着运行。表面发出带有白色的蓝绿光彩，天王星的直径约为地球的四倍。";
        CamreaControl.Instance.SelectState = 7;
    }
}
