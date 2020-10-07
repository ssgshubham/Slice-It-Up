using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscreen : MonoBehaviour
{
    public void startgame()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void scenechange()
    {
        SceneManager.LoadScene(3);
    }

    public void scenechanger()
    {
        SceneManager.LoadScene(4);
    }

    public void scene2()
    {
        SceneManager.LoadScene(1);
    }
}
