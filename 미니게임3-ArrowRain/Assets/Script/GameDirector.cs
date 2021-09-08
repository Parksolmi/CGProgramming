using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGage;

    void Start()
    {
        this.hpGage = GameObject.Find("hpGuage");
    }

    public void DecreaseHP()
    {
        hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }

    void Update()
    {
        
    }
}
