using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gmanager2 : MonoBehaviour
{
    public Text st;
    private int cs;
    

    public void UpdateScore(int s)
    {
        cs += s;
        st.text = cs.ToString();

        if (cs > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", cs);
           
        }

    }

   
}
