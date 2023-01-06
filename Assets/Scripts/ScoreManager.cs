using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get;set;}

    [SerializeField] private TextMeshProUGUI scoreText;    

    public int score {get;set;}


    public void Start()
    {
        Instance = this;
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
}
