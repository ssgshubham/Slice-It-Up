using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class gmmanager : MonoBehaviour
{
   
    public Text scoreText;
    private int currentScore;
    public Text highscoretext;

    void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
       
       
    }

    public void UpdateScore(int score)
    {
        currentScore += score;
        scoreText.text = currentScore.ToString(); 

        if(currentScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            highscoretext.text = currentScore.ToString();
        }
        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highscoretext.text = "0";
    }


}
