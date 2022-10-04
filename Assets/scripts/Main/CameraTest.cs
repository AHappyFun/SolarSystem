using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour {

    float x;
    float y;
    public float speed;
    Vector3 center;
    public Transform centerObj;
    public float distance;
    // Use this for initialization
    void Start () {
        center = centerObj.gameObject.transform.position;
	}
 
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            y += Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            Quaternion q = Quaternion.Euler(y, x, 0);
            Vector3 direction = q * Vector3.forward;
            this.transform.position = center - direction * distance;
            this.transform.LookAt(center);
        }
    }
            
}
