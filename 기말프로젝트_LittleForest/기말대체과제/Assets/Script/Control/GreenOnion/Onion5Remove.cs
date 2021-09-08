using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion5Remove : MonoBehaviour
{
    GameObject GOC; //GOC=GreenOnionCutting

    private void Start()
    {
        GOC = GameObject.Find("GreenOnionCutting5");
    }

    public void ButtonClick()
    {
        //제거
        GOC.SetActive(false);
    }
}
