using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCickExplainPane : MonoBehaviour {
    public GameObject explainPanel;
    private Animator anim;
    // Use this for initialization
    void Start () {
        anim = explainPanel.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
 
    public void OnclickPanel()
    {
        //explainPanel.SetActive(false);
        anim.SetBool("isStart",false);
    }
    public void OnExplainNoAppear()
    {
        explainPanel.SetActive(false);
    }
   
}
