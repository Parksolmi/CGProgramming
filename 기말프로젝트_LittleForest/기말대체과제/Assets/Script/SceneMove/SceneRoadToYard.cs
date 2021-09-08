using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRoadToYard: MonoBehaviour
{
    void Update()
    {
        //플레이어가 오른쪽 화면 밖으로 나갔다면 씬이동
        if (transform.position.x > 2.5)
        {
            SceneManager.LoadScene("HouseYard");
        }
    }

}
