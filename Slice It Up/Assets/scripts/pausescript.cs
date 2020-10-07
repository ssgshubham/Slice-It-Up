using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausescript : MonoBehaviour
{
    public void youwin()
    {
        Time.timeScale = 0f;
    }

    public void timerestart()
    {
        Time.timeScale = 1f;
    }
}
