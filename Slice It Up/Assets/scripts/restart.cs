using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    

    public void scenechange()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

   
}
