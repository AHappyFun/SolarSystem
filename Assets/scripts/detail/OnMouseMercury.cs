using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseMercury : MonoBehaviour {

    public GameObject msgBasic;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseEnter()
    {
        msgBasic.SetActive(true);
    }
    private void OnMouseOver()
    {
        msgBasic.SetActive(false);
    }
    
}
