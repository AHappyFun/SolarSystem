using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stringControl : MonoBehaviour {
    private Text textGuangnian;
	// Use this for initialization
	void Start () {
        textGuangnian = GetComponent<Text>();
        textGuangnian.text = "0-0光年";
        StartCoroutine(add());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator add()
    {
        for (int i = 80; i < 125; i++)
        {
            textGuangnian.text = i-46+"-"+i+"光年";
            yield return new WaitForSeconds(0.005f);
        }
      
    }
}
