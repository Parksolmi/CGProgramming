using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoilingAnimation : MonoBehaviour
{
    Animator animator;
    AudioSource audioSrc;

    //오디오클립
    AudioClip waterBoiling;

    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        Invoke("Boiling", 4f);
    }

    //4초 후에 WaterBoiling애니메이션 재생
    void Boiling()
    {
        this.animator.SetBool("IsBoiling", true);
        audioSrc.Play();
    }

}
