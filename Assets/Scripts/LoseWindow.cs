using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public void PlayerLose()
    {
        int score = ScoreManager.Instance.score;
        scoreText.text = ScoreManager.Instance.score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if(score > bestScore)
        {
            bestScore = score;
        }
        bestScoreText.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
