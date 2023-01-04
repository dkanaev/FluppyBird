using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get;set;}

    [SerializeField] private TextMeshProUGUI scoreText;    

    private int score;


    public void Start()
    {
        Instance = this;
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
    }
}
