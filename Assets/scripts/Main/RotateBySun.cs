using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBySun : MonoBehaviour {
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(new Vector3(0f, 0f, 0f), new Vector3(0f, 1f, 0f), Speed);
    }
}
