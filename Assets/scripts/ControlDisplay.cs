using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlDisplay : MonoBehaviour {

    // Use this for initialization
    public GameObject[] StarArray;
    //public Sprite[] imageHigh;
    //public Sprite[] imageLow;
    //private Image[] imageArray;
    private bool[] isDisplay=new bool[8];
	void Start ()
    {
    }

    public void OnClickImage1()
    {
        
        if (isDisplay[0]==false)
        {
            StarArray[0].SetActive(false);
            isDisplay[0] = true;

        }
        else
        {
            StarArray[0].SetActive(true);
            isDisplay[0] = false;
        }
       
        
    }
    public void OnClickImage2()
    {
        if (isDisplay[1] == false)
        {
            StarArray[1].SetActive(false);
            isDisplay[1] = true;

        }
        else
        {
            StarArray[1].SetActive(true);
            isDisplay[1] = false;
        }
    }
    public void OnClickImage3()
    {
        if (isDisplay[2] == false)
        {
            StarArray[2].SetActive(false);
            isDisplay[2] = true;

        }
        else
        {
            StarArray[2].SetActive(true);
            isDisplay[2] = false;
        }
    }
    public void OnClickImage4()
    {
        if (isDisplay[3] == false)
        {
            StarArray[3].SetActive(false);
            isDisplay[3] = true;

        }
        else
        {
            StarArray[3].SetActive(true);
            isDisplay[3] = false;
        }
    }
    public void OnClickImage5()
    {
        if (isDisplay[4] == false)
        {
            StarArray[4].SetActive(false);
            isDisplay[4] = true;

        }
        else
        {
            StarArray[4].SetActive(true);
            isDisplay[4] = false;
        }
    }
    public void OnClickImage6()
    {
        if (isDisplay[5] == false)
        {
            StarArray[5].SetActive(false);
            isDisplay[5] = true;

        }
        else
        {
            StarArray[5].SetActive(true);
            isDisplay[5] = false;
        }
    }
    public void OnClickImage7()
    {
        if (isDisplay[6] == false)
        {
            StarArray[6].SetActive(false);
            isDisplay[6] = true;

        }
        else
        {
            StarArray[6].SetActive(true);
            isDisplay[6] = false;
        }
    }
    public void OnClickImage8()
    {
        if (isDisplay[7] == false)
        {
            StarArray[7].SetActive(false);
            isDisplay[7] = true;

        }
        else
        {
            StarArray[7].SetActive(true);
            isDisplay[7] = false;
        }
    }
}
