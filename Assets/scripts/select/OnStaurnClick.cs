using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnStaurnClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 6;
        msgText.text = "土星是一个几乎和木星一样大的气体巨星，是太阳系第二大啊行星，有着美丽的环，在地球上以一般的望远镜即可看见，有一个极薄但却很宽的环状系统，主要是由冰及尘粒构成。";
    }
}
