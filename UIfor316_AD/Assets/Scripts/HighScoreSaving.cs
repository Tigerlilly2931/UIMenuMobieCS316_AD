using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreSaving : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    private string score = "Score";
    private int actualScore;
    // Start is called before the first frame update
    void Start()
    {
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt(score).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score: " + actualScore;
    }

    public void AddPoint()
    {
        actualScore++;
        if(PlayerPrefs.GetInt(score) <= actualScore)
        {
            PlayerPrefs.SetInt(score, actualScore);
        }
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt(score).ToString();
    }
}
