using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public int highscore = 0;
    string highScoreKey = "HighScore";
    public float scoreAmount;
    public float pointIncPerSecond;

    public Text scoretext;
    public Text highscoretext;

    public bool scoreActive = true;

    private void Start()
    {
        scoreActive = true;
        scoreAmount = 0f;
        pointIncPerSecond = 1f;
        highscore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    void FixedUpdate()
    {
        if (scoreActive == true)
        {
            scoretext.text = (int)scoreAmount + "";
            scoreAmount += pointIncPerSecond * Time.deltaTime;
        }
        
        highscoretext.text = highscore.ToString();
        if (highscore < scoreAmount)
        {
            PlayerPrefs.SetInt(highScoreKey, (int)scoreAmount);
            PlayerPrefs.Save();
        }
    }
}
