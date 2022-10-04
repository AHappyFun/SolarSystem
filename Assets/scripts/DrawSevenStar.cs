using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrawSevenStar : MonoBehaviour {

    //public Animator anim;
    public GameObject drawBtn;
    public GameObject drawPrefab;
    public Sprite[] PauseAndPlay;
    public Image icon;
    private bool isPause=true;
    private TrailRenderer trailRenderer;
	void Start () {
        //anim = GetComponent<Animator>();
        //trailRenderer = GetComponent<TrailRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (isPause == true)
        {
            icon.GetComponent<Image>().sprite = PauseAndPlay[0];
        }
        else
        {
            icon.GetComponent<Image>().sprite = PauseAndPlay[1];
        }
    }
    public void DrawFunct()
    {
      
        Instantiate(drawPrefab,new Vector3(-6.99f,0.31f,0),Quaternion.identity);
        //anim.SetBool("isDraw",true);
        //trailRenderer.time = 3;
        isPause = false;
        Invoke("ChangePause",8f);
    }
    void ChangePause()
    {
        isPause = true;
    }
    
}
