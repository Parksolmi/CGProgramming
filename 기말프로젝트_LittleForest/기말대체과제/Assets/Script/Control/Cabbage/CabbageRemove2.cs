using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageRemove2 : MonoBehaviour
{
    GameObject CB; //CB=Cabbage

    private void Start()
    {
        CB = GameObject.Find("CabbageCutting2");
    }

    public void ButtonClick()
    {
        //제거
        CB.SetActive(false);
    }
}
