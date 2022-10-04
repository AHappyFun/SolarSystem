using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weidu : MonoBehaviour
{
    private Text textweidu;
    // Use this for initialization
    void Start()
    {
        textweidu = GetComponent<Text>();
    }
    [HideInInspector]
    public static bool isWeidu;
    [HideInInspector]
    public static int index;
    // Update is called once per frame
    void Update()
    {
        if (isWeidu)
        {
            switch (index)
            {
                case 1:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 2:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 3:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 4:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 5:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 6:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                case 7:
                    textweidu.text = "+0 0' 0\"";
                    StartCoroutine(Addweidu(62));
                    break;
                default:
                    break;
            }
            isWeidu = false;
        }
    }
    IEnumerator Addweidu(int a)
    {
        for (int i = 0; i < a; i++)
        {
            textweidu.text = "+"+i+" "+(i-16)+"' "+(i-57.8)+"\"";
            yield return new WaitForSeconds(0.005f);
        }
        switch (index)
        {
            case 1:
                textweidu.text = "+61 45' 03.2\"";
                break;
            case 2:
                textweidu.text = "+56 22' 56.6\"";
                break;
            case 3:
                textweidu.text = "+53 41' 41.1\"";
                break;
            case 4:
                textweidu.text = "++57 01' 57.3\"";
                break;
            case 5:
                textweidu.text = "+55 57' 35.6\"";
                break;
            case 6:
                textweidu.text = "+54 55' 31.4\"";
                break;
            case 7:
                textweidu.text = "+49 18' 48.1\"";
                break;
            default:
                break;
        }
    }
}

