using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirMsgControl : MonoBehaviour {

    public Text[] msg;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (selectPlanet.indexRevote-1)
        {
            case 0:
                msg[0].text = "赤道半径:  2439km";
                msg[1].text = "自转周期:  58.65days";
                msg[2].text = "公转周期:  87.97days";
                break;
            case 1:
                msg[0].text = "赤道半径:  6051km";
                msg[1].text = "自转周期:  243days";
                msg[2].text = "公转周期:  244.7days";
                break;
            case 2:
                msg[0].text = "赤道半径:  6371km";
                msg[1].text = "自转周期:  1days";
                msg[2].text = "公转周期:  365.2days";
                break;
            case 3:
                msg[0].text = "赤道半径:  3398km";
                msg[1].text = "自转周期:  1.026days";
                msg[2].text = "公转周期:  687days";
                break;
            case 4:
                msg[0].text = "赤道半径:  71398km";
                msg[1].text = "自转周期:  0.41days";
                msg[2].text = "公转周期:  11.86days";
                break;
            default:
                break;
        }
    }
}
