using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowFootprint1 : MonoBehaviour
{
    AudioSource audioSrc;



    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        //방향키가 눌릴 때 효과음 출력
        if (Input.GetKeyDown(KeyCode.RightArrow)
            || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            audioSrc.Play();
        }
        //방향키를 뗄 때 효과음 멈춤
        if (Input.GetKeyUp(KeyCode.RightArrow)
            || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            audioSrc.Pause();
        }


    }
}
