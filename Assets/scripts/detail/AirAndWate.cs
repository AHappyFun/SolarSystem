using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirAndWate : MonoBehaviour {

    public GameObject airPlanet;
    public GameObject waterPlanet;
    // private bool isWaterDis; //是否是水shader
    public GameObject msgBasic;   //基本信息
    public GameObject percentMsg;   //百分百含量

    public GameObject btnAir;
    public GameObject btnWater;
    private Animator anim;
    private void Start()
    {
        airPlanet.SetActive(true);
        btnAir.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
        waterPlanet.SetActive(false);
        anim = msgBasic.GetComponent<Animator>();
        anim.SetBool("isDis", true);
    }

    public void OnClickAir()
    {
        //isWaterDis = false;
        btnAir.GetComponent<Image>().color = new Color(1f,1f,1f,1f);
        btnWater.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
        airPlanet.SetActive(true);
        msgBasic.SetActive(true);
        waterPlanet.SetActive(false);
        percentMsg.SetActive(false);
        anim.SetBool("isDis", true);
    }
    public void OnClickWater()
    {
        //isWaterDis = true;
        btnWater.GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
        btnAir.GetComponent<Image>().color = new Color(1f, 1f, 1f, 0.5f);
        airPlanet.SetActive(false);
        msgBasic.SetActive(false);
        waterPlanet.SetActive(true);
        percentMsg.SetActive(true);
        anim.SetBool("isDis", false);
    }
}
