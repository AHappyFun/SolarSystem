using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnEarthClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 3;
        msgText.text = "地球是有一卫星称为月亮，是唯一己知有生命存在的行星。地球的大气层能阻挡来自太阳有害人体的辐射，防止气温急遽下降。地球表面有百分之七十为水，同时地磁场也在保护着地球上的生命。";
    }
}
