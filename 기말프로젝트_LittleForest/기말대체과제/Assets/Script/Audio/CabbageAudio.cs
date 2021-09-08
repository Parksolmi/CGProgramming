using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageAudio : MonoBehaviour
{
    AudioSource audioSrc;

    //오디오클립
    public AudioClip cuttingCabbage;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void ButtonClick()
    {
        //오디오 출력
        audioSrc.PlayOneShot(cuttingCabbage, 0.5f);
    }
}
