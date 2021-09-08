using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingSound : MonoBehaviour
{
    AudioSource audioSrc;

    //물이 든 냄비 이미지가 활성화 되면 물 효과음을 튼다.
    public void clickButton()
    {
        audioSrc = GetComponent<AudioSource>();
        {
            audioSrc.Play();
        }
    }
}
