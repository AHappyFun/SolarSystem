using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class percentMsgControl : MonoBehaviour {

    public Text[] msg;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (selectPlanet.indexRevote - 1)
        {
            case 0:
                msg[0].text = "He";
                msg[1].text = "Na";
                msg[2].text = "O";
                break;
            case 1:
                msg[0].text = "CO2";
                msg[1].text = "N";
                msg[2].text = "*";
                break;
            case 2:
                msg[0].text = "N";
                msg[1].text = "O";
                msg[2].text = "*";
                break;
            case 3:
                msg[0].text = "CO2";
                msg[1].text = "Ar";
                msg[2].text = "H2O";
                break;
            case 4:
                msg[0].text = "H2";
                msg[1].text = "He";
                msg[2].text = "*";
                break;
            default:
                break;
        }
    }
}
