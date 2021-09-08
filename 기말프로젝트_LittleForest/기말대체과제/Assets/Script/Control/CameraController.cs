using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //카메라 가두기 (바깥 선을 벗어나지 못하게 하기)
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
        playerPos.x, playerPos.y, transform.position.z);
    }
}
