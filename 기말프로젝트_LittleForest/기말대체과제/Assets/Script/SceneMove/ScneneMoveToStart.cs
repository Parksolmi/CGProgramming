﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScneneMoveToStart : MonoBehaviour
{
    public void ClickButton()
    {
        SceneManager.LoadScene("GameStart");
    }
}
