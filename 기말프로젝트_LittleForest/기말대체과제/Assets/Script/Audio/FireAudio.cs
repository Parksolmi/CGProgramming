using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAudio : MonoBehaviour
{
    AudioSource audioSrc;

    //오디오클립
    public AudioClip setFire;

    //게임오브젝트
    GameObject Fire;

    void Start()
    {
        //가스 불이 켜지면 불 효과음을 튼다.
        audioSrc = GetComponent<AudioSource>();
        Fire = GameObject.Find("Fire");

        if (Fire.activeSelf == true)
        {
            audioSrc.PlayOneShot(setFire, 0.5f);
        }

    }

}
