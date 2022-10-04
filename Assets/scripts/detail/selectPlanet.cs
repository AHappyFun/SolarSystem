using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectPlanet : MonoBehaviour {

    public Sprite[] planetList;   //星球图
    public Sprite[] planetRightDown; //右下角数组
    public GameObject[] texPlanetName; //星球名字数组
    public GameObject air;
    public GameObject water;   // 两个面板
    

    public static int indexRevote=1; //切换序列

	
	void Update ()
    {
        DisplayName(texPlanetName,indexRevote-1);
    }
    public void OnClickRevote()
    {
        Debug.Log(indexRevote);
        if (indexRevote<5)
        {
            indexRevote++;
        }
        else
        {
            indexRevote = 1;
        }
        switch (indexRevote)
        {
            case 1:
                water.GetComponent<SpriteRenderer>().sprite = planetList[0];
                this.gameObject.GetComponent<Image>().sprite = planetRightDown[0];
                air.GetComponent<SpriteRenderer>().sprite = planetList[0];
                break;
            case 2:
                water.GetComponent<SpriteRenderer>().sprite = planetList[1];
                this.gameObject.GetComponent<Image>().sprite = planetRightDown[1];
                air.GetComponent<SpriteRenderer>().sprite = planetList[1];
                break;
            case 3:
                water.GetComponent<SpriteRenderer>().sprite = planetList[2];
                this.gameObject.GetComponent<Image>().sprite = planetRightDown[2];
                air.GetComponent<SpriteRenderer>().sprite = planetList[2];
                break;
            case 4:
                water.GetComponent<SpriteRenderer>().sprite = planetList[3];
                this.gameObject.GetComponent<Image>().sprite = planetRightDown[3];
                air.GetComponent<SpriteRenderer>().sprite = planetList[3];
                break;
            case 5:
                water.GetComponent<SpriteRenderer>().sprite = planetList[4];
                this.gameObject.GetComponent<Image>().sprite = planetRightDown[4];
                air.GetComponent<SpriteRenderer>().sprite = planetList[4];
                break;
            default:
                break;
        }

    }
    void DisplayName(GameObject[] texName,int index)
    {
        for (int i = 0; i < texName.Length; i++)
        {
            if (i==index)
            {
                texName[i].SetActive(true);
            }
            else
            {
                texName[i].SetActive(false);
            }
        }
    }
}
