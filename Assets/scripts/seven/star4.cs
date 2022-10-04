using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class star4 : MonoBehaviour
{

    public GameObject Camera;
    private Animator animCam;
    public Text guangnian;
    public GameObject jinweidu;
    void Start()
    {
        animCam = Camera.GetComponent<Animator>();
    }
    bool star4bool = true;
    private void OnMouseDown()
    {
        if (star4bool)
        {
            animCam.SetBool("star4", true);
            star4bool = false;
            StartCoroutine(Add(81, guangnian));
            jinweidu.SetActive(true);
            jindu.index = 4;
            weidu.index = 4;
            jindu.isJindu = true;
            weidu.isWeidu = true;
        }
        else
        {
            animCam.SetBool("star4", false);
            star4bool = true;
            StartCoroutine(Addback(guangnian));
            jinweidu.SetActive(false);
        }
    }
    IEnumerator Add(int a, Text text)
    {
        for (int i = 50; i < a + 1; i++)
        {
            text.text = i + "光年";
            yield return new WaitForSeconds(0.005f);
        }
    }
    IEnumerator Addback(Text text)
    {
        for (int i = 80; i < 125; i++)
        {
            text.text = i - 46 + "-" + i + "光年";
            yield return new WaitForSeconds(0.005f);
        }
    }
}
