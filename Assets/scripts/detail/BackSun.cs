using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackSun : MonoBehaviour {

    public GameObject startUI;
    public void SunScene()
    {
        startUI.SetActive(true);
        Invoke("SunWait", 1.2f);
    }
    public void SunWait()
    {
        SceneManager.LoadScene(0);
    }
}
