using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextBox : MonoBehaviour
{
    public GameObject textBox;

    void OnCollisionEnter2D(Collision2D collision) 
    {
        textBox.SetActive(true);  //활성화시키기
    }
}
