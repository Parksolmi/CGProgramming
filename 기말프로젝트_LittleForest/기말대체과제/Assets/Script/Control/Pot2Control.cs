using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot2Control : MonoBehaviour
{
    GameObject pot2;

    //물 버튼이 클릭되어 potOfWater이미지가 나타나면
    //pot2는 비활성화시키기
    public void clickButton()
    {
        pot2 = GameObject.Find("Pot2");
        pot2.SetActive(false);
    }
}
