using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMsgDisControl : MonoBehaviour {
    public GameObject msgAir;
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim =msgAir. GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //private void OnMouseEnter()
    //{
    //    anim.SetBool("isDis",true);
    //}
    //private void OnMouseExit()
    //{
    //    anim.SetBool("isDis",false);
    //}
}
