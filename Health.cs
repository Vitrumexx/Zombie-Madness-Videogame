using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class Health : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI TimerText;
    [SerializeField] private TextMeshProUGUI CornText;
    [SerializeField] private TextMeshProUGUI CoinText;
    [SerializeField] private TextMeshProUGUI CarrotText;

    private Transform enemy;
    public static int TotalCoinAmount;
    public static int HighScore;
    public static int _time = 0;
    void Start()
    {
        TotalCoinAmount = PlayerPrefs.GetInt("Money");
        HighScore = PlayerPrefs.GetInt("HighScore");
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        StartCoroutine(ExecuteAfterTime());
        _time = _time - _time;
        Coin.Coins = Coin.Coins - Coin.Coins;
    }

    void Update()
    {
        TakeCoin();
        TakeCorn();
        TakeCarrot();
        if (Enemy.isTouched)
        {
            SceneManager.LoadScene(2);
            TotalCoinAmount = TotalCoinAmount + Coin.Coins;
            Enemy.isTouched = false;
            PlayerPrefs.SetInt("Money", TotalCoinAmount);
        }
        else if (Corn.Corns == 10 && Carrot.Carrots == 3)
        {
            SceneManager.LoadScene(3);
            TotalCoinAmount = TotalCoinAmount + Coin.Coins;
            Enemy.isTouched = false;
            PlayerPrefs.SetInt("Money", TotalCoinAmount);
        }
    }
    void TakeCoin()
    {
        CoinText.SetText((Coin.Coins).ToString());
    }

    void TakeCorn()
    {
        CornText.SetText((Corn.Corns).ToString() + "/10");
    }

    void TakeCarrot()
    {
        CarrotText.SetText((Carrot.Carrots).ToString() + "/3");
    }
    void TimeUpd()
    {
        _time++;
        TimerText.SetText((_time).ToString());

    }

    IEnumerator ExecuteAfterTime()
    {
        while (SceneManager.GetActiveScene().name == "SampleScene")
        {
            yield return new WaitForSeconds(1);
            TimeUpd();
        }
    }
}
