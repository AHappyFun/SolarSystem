using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jindu : MonoBehaviour
{
    private Text textjindu;
    // Use this for initialization
    void Start()
    {
        textjindu = GetComponent<Text>();

    }
    [HideInInspector]
    public static bool isJindu;
    [HideInInspector]
    public static int index;
    // Update is called once per frame
    void Update()
    {
        if (isJindu)
        {
            switch (index)
            {
                case 1:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                case 2:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));         
                    break;
                case 3:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                case 4:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                case 5:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                case 6:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                case 7:
                    textjindu.text = "0h 0m 0s";
                    StartCoroutine(Add(12));
                    break;
                default:
                    break;
            }
            
            isJindu = false;
        }
    }
    IEnumerator Add(int a)
    {
        for (int i = -50; i < a; i++)
        {
            textjindu.text =i+"h "+(i-7)+"m "+(i+32.70)+"s";
            yield return new WaitForSeconds(0.005f);
        }
        switch (index)
        {
            case 1:
                textjindu.text = "11h 04m 43.7s";
                break;
            case 2:
                textjindu.text = "11h 01m 50.49s";
                break;
            case 3:
                textjindu.text = "11h 53m 49.83s";

                break;
            case 4:
                textjindu.text = "12h 15m 25.57s";
                break;
            case 5:
                textjindu.text = "12h 54m 01.76s";
                break;
            case 6:
                textjindu.text = "13h 23m 55.55s";
                break;
            case 7:
                textjindu.text = "13h 47m 32.44s";
                break;
            default:
                break;
        }

    }
}

