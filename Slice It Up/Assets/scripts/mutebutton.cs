using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mutebutton : MonoBehaviour
{
    public GameObject Controlbutton;
    public Sprite onb;
    public Sprite offb;

    void Start()
    {
        if(AudioListener.pause == true)
        {
            Controlbutton.GetComponent<Image> ().sprite = offb;
        }
        else
        {
            Controlbutton.GetComponent<Image> ().sprite = onb;
        }
    }

   

    public void SoundControl()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            Controlbutton.GetComponent<Image> ().sprite = onb;
        }
        else
        {
            AudioListener.pause = true;
            Controlbutton.GetComponent<Image> ().sprite = offb;
        }
    }
}
