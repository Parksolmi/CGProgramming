using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoybeanButton : MonoBehaviour
{
    Animator animator;
    GameObject PotOfWater2;

    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    public void clickButton()
    {
        animator.SetBool("PutSoybean", true);
    }
}
