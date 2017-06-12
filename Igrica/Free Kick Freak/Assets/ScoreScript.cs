using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    public static int score = 0;

    public Text scoreText;

    string SCORE = "Score: ";
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        refreshScore();
        if(score == 50)
        {
            score = 0;
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void refreshScore()
    {
        scoreText.text = SCORE + score.ToString();
    }

    public void addScore()
    {
        score += 10;
    }
}
