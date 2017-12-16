using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //important

public class Distance : MonoBehaviour
{

    public Text ScoreText;
    int score = 0;

    public void UpdateScore()
    {
        score++;
        ScoreText.text = "Distance: " + score;
    }
    public void UpdateScore(int newScore)
    {
        score = newScore;
        ScoreText.text = "Distance: " + score;
    }
}