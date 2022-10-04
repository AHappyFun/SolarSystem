using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sevenPanel : MonoBehaviour {

    public GameObject panel;

    private bool IsShow = false;

    private void OnMouseDown()
    {
        if (!IsShow)
            panel.SetActive(true);
        else
            panel.SetActive(false);
        IsShow = !IsShow;
    }

   
}
