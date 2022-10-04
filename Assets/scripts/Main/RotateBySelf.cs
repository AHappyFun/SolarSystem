using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateBySelf : MonoBehaviour {
    public float rotateSpeed;

    public GameObject explainPanel;
    private Animator anim;   //获取解释面板动画控制器
    public Text explainText;   //解释名字


	void Start ()
    {
        anim = explainPanel.GetComponent<Animator>();   
	}
	
	void Update ()
    {
        transform.Rotate(new Vector3(0, rotateSpeed, 0) * Time.deltaTime);  
    }   
    private void OnMouseDown()
    {
      
        explainPanel.SetActive(true);
        anim.SetBool("isStart",true);
        string tempStr = this.name.ToString();
        char[] tempChar = tempStr.ToCharArray();
        string displayText = ""; ;
        for (int i = 0; i < tempChar.Length; i++)
        {
             displayText += tempChar[i]+" ";
        }
        explainText.text = displayText;       
    }
}
