using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAudio : MonoBehaviour
{
    AudioSource audioSrc;

    //오디오클립
    public AudioClip setWater;

    //게임오브젝트
    GameObject potOfWater; //물이 든 냄비 이미지를 저장할 변수

   //물이 든 냄비 이미지가 활성화 되면 물 효과음을 튼다.
    public void clickButton()
    {
        audioSrc = GetComponent<AudioSource>();
        potOfWater = GameObject.Find("PotOfWater");

        if (potOfWater.activeSelf == true)
        {
            audioSrc.PlayOneShot(setWater, 0.5f);
        }
    }

}
