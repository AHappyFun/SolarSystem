using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPanel : MonoBehaviour {

    private Animator anim;
    public GameObject menuBtn;
    public GameObject startUI;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    public void menuAppear()
    {
        anim.SetBool("isAppear",true);
        menuBtn.SetActive(false);

    }

    public void menuLeave()
    {
        anim.SetBool("isAppear",false);
        menuBtn.SetActive(true);
    }
    
    public void GalaxyScene()
    {
        startUI.SetActive(true);
        Invoke("GalaxyWait",1.2f);
    }
    public void SunStarScene()
    {
        startUI.SetActive(true);
        Invoke("SunStarWait", 1.2f);
    }
    public void SevenStarScene()
    {
        startUI.SetActive(true);
        Invoke("SevenStarWait", 1.2f);
    }
    public void DetailScene()
    {
        startUI.SetActive(true);
        Invoke("DetailWait", 1.2f);
    }
    public void ARScene()
    {
        startUI.SetActive(true);
        Invoke("ARWait", 1.2f);
    }
    public  void ARWait()
    {
        SceneManager.LoadScene(4);
    }
    public void DetailWait()
    {
        SceneManager.LoadScene(3);
    }
    public void GalaxyWait()
    {
        SceneManager.LoadScene(1);
    }
    public void SunStarWait()
    {
        SceneManager.LoadScene(0);
    }
    public void SevenStarWait()
    {
        SceneManager.LoadScene(2);
    }


}
