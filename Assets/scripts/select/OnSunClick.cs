using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnSunClick : MonoBehaviour {

    public Text msgText;   //星球信息
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        CamreaControl.Instance.SelectState = 0;
        msgText.text = "太阳是太阳系的中心天体，占有太阳系总体质量的99.86%。太阳系中的八大行星、小行星、流星、彗星、外海王星天体以及星际尘埃等，都围绕着太阳公转，而太阳则围绕着银河系的中心公转。";
    }
}
