using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get;set;}

    [SerializeField] private TextMeshProUGUI scoreText;    

    public int score {get;set;}
    public AudioClip scoreAudioClip;


    public void Start()
    {
        Instance = this;
    }

    public void SetScore(int score)
    {
        this.score += score;
        GetComponent<AudioSource>().PlayOneShot(scoreAudioClip);
        scoreText.text = this.score.ToString();
    }
}
