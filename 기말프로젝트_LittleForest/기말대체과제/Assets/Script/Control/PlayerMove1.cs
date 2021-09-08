using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove1 : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    public float walkForce;
    public float maxWalkSpeed;

    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {
        //플레이어 이동
        int RLkey = 0; //좌우 이동 키
        if (Input.GetKey(KeyCode.RightArrow)) RLkey = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) RLkey = -1;
        
        //플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        //플레이어 스피드 제한
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * RLkey * this.walkForce);
        }

        //플레이어가 움직이는 방향에 따라 반전
        if(RLkey != 0)
        {
            transform.localScale = new Vector3(RLkey, 1, 1);
        }

        //Walk애니메이션 실행
        if (Mathf.Abs(rigid2D.velocity.x) < 0.3)
        {
            this.animator.SetBool("WalkSide", false);
            this.animator.SetBool("WalkFront", false);
            this.animator.SetBool("WalkBack", false);
        }
        else
        {
            this.animator.SetBool("WalkSide", true);
            this.animator.SetBool("WalkFront", false);
            this.animator.SetBool("WalkBack", false);
        }
    }
}
