using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot1Control : MonoBehaviour
{
    GameObject pot;

    // Start is called before the first frame update
    void Start()
    {
        pot = GameObject.Find("Pot1");
    }

    //pot2가 나오면 pot1이 사라지도록 한다.
    public void clickButton()
    {
        pot.SetActive(false);
    }
}
