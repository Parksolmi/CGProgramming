using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenOnionAudio : MonoBehaviour
{
    AudioSource audioSrc;

    //오디오클립
    public AudioClip cuttingGreenOnion;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        //오디오 출력
        audioSrc.PlayOneShot(cuttingGreenOnion, 0.5f);
    }
}
