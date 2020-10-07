﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spashscrn : MonoBehaviour
{
    public int SceneNumber;
    void Start()
    {
        if (SceneNumber == 0)
        {
            StartCoroutine(ToSplashTwo());
        }

        if (SceneNumber == 1)
        {
            StartCoroutine(ToSplashThree());
        }
    }

    IEnumerator ToSplashTwo()
    {
        yield return new WaitForSeconds(7);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }
    IEnumerator ToSplashThree()
    {
        yield return new WaitForSeconds(5);
        SceneNumber = 2;
        SceneManager.LoadScene(2);
    }

}
