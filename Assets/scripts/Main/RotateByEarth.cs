using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByEarth : MonoBehaviour {
    public Transform earth;
    public float Speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(earth.position, new Vector3(0f, 1f, 0f), Speed);
    }
}
