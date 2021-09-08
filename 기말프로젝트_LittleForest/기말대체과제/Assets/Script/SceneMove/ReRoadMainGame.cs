using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReRoadMainGame : MonoBehaviour
{
    public void clickButton()
    { 
        SceneManager.LoadScene("MainGame");
    }
}
