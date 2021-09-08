using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCabbage : MonoBehaviour
{
    //배추가 익어감.
    GameObject CabbageImage6;

    GameObject CabbageImage1;
    GameObject CabbageImage2;
    GameObject CabbageImage3;
    GameObject CabbageImage4;
    GameObject CabbageImage5;
   

    void Start()
    {
        CabbageImage6 = GameObject.Find("CabbageImage6");
        
        Invoke("RemoveGreenCabbage", 4f);
    }

    // 4초가 지나면 초록 배추를 없애고 노란 배추가 나오게 하여
    //음식이 익어감을 나타낸다.
    void RemoveGreenCabbage()
    {
        if(CabbageImage6.activeSelf)
        {
            CabbageImage1 = GameObject.Find("CabbageImage1");
            CabbageImage2 = GameObject.Find("CabbageImage2");
            CabbageImage3 = GameObject.Find("CabbageImage3");
            CabbageImage4 = GameObject.Find("CabbageImage4");
            CabbageImage5 = GameObject.Find("CabbageImage5");
            CabbageImage1.SetActive(false);
            CabbageImage2.SetActive(false);
            CabbageImage3.SetActive(false);
            CabbageImage4.SetActive(false);
            CabbageImage5.SetActive(false);
            CabbageImage6.SetActive(false);
        }
    }
}
