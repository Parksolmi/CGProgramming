using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SauceAudio : MonoBehaviour
{
    AudioSource audioSrc;

    //오디오클립
    public AudioClip addSauce;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    //소스버튼을 클릭하면 소스 효과음을 튼다.
    public void ClickButton()
    {
        audioSrc.PlayOneShot(addSauce, 0.5f);
    }
}
