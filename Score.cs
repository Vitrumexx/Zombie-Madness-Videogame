using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
    
{
    public static int score;
    [SerializeField] private TextMeshProUGUI ScoreText;
    void Start()
    {
        
    }
    void Update()
    {
        score = (Health._time * 5) + (Coin.Coins * 20) + (Corn.Corns * 50);
        ScoreText.SetText("Score: " + (score).ToString());
        if (score > (PlayerPrefs.GetInt("HighScore")))
            PlayerPrefs.SetInt("HighScore", score);
    }
}
