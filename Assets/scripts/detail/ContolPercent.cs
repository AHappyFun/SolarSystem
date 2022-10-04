using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContolPercent : MonoBehaviour {

    public GameObject[] percent;   //3个百分百
    private Image image1;
    private Image image0;
    private Image image2;

    public float speed;
	void Start () {    
        image1 = percent[1].GetComponent<Image>();
        image2 = percent[2].GetComponent<Image>();
        image0 = percent[0].GetComponent<Image>();
    }
    Planet mercury = new Planet(new float[] { 42f, 42f, 15f });
    Planet venus = new Planet(new float[] { 96.5f, 3.4f, 0.1f });
    Planet earth = new Planet(new float[] { 78.1f, 20.9f, 0.93f });
    Planet mars = new Planet(new float[] { 50f, 30f, 20f });
    Planet jupiter = new Planet(new float[] { 81f, 18f, 1f });
    float currentAmout = 0;
    float currentAmout1 = 0;
    float currentAmout2 = 0;

    float process0, process1, process2;
    void Update () {
        
        switch (selectPlanet.indexRevote-1)
        {         
            case 1:
                process0 = venus.targetProcess[0];
                process1 = venus.targetProcess[1];
                process2 = venus.targetProcess[2];
                break;
            case 2:
                process0 = earth.targetProcess[0];
                process1 = earth.targetProcess[1];
                process2 = earth.targetProcess[2];
                break;
            case 3:
                process0 = mars.targetProcess[0];
                process1 = mars.targetProcess[1];
                process2 = mars.targetProcess[2];
                break;
            case 4:
                process0 = jupiter.targetProcess[0];
                process1 = jupiter.targetProcess[1];
                process2 = jupiter.targetProcess[2];
                break;
            case 0:
                process0 = mercury.targetProcess[0];
                process1 = mercury.targetProcess[1];
                process2 = mercury.targetProcess[2];
                break;
            default:
                break;
        }

        if (currentAmout <process0)     //第一个环
        {           
           currentAmout += speed;
            if (currentAmout > process0)
                currentAmout = process0;        
            image0.GetComponent<Image>().fillAmount = currentAmout / 100.0f;
        }
        if (currentAmout > process0)     //第一个环
        {
            currentAmout -= speed;
            if (currentAmout < process0)
                currentAmout = process0;
            image0.GetComponent<Image>().fillAmount = currentAmout / 100.0f;
        }
        if (currentAmout1 < process1)     //第二个环
        {
            currentAmout1 += speed;
            if (currentAmout1 > process1)
                currentAmout1 = process1;
            image1.GetComponent<Image>().fillAmount = currentAmout1 / 100.0f;
        }
        if (currentAmout1 > process1)     //第二个环
        {
            currentAmout1 -= speed;
            if (currentAmout1 < process1)
                currentAmout1 = process1;
            image1.GetComponent<Image>().fillAmount = currentAmout1 / 100.0f;
        }
        if (currentAmout2 < process2)     //第三个环
        {
            currentAmout2 += speed;
            if (currentAmout2 > process2)
                currentAmout2 = process2;
            image2.GetComponent<Image>().fillAmount = currentAmout2 / 100.0f;
        }
        if (currentAmout2 > process2)     //第三个环
        {
            currentAmout2 -= speed;
            if (currentAmout2 < process2)
                currentAmout2 = process2;
            image2.GetComponent<Image>().fillAmount = currentAmout2 / 100.0f;
        }
    }
}
public class Planet
{
    public float[] targetProcess;
    public Planet(float[] process)
    {
        targetProcess = process;
    }
}
