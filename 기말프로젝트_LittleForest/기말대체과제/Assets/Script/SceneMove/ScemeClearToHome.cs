using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScemeClearToHome : MonoBehaviour
{
    public void clickButton()
    {
        SceneManager.LoadScene("ReHome");
    }
}
