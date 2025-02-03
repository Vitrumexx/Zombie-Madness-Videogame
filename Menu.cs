using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TextCoinAmount;
    [SerializeField] private TextMeshProUGUI TextHighScore;
    private void Start()
    {
        Health.TotalCoinAmount = PlayerPrefs.GetInt("Money");
        TextCoinAmount.SetText(Health.TotalCoinAmount.ToString());
        TextHighScore.SetText("High Score: " + (PlayerPrefs.GetInt("HighScore")).ToString());
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
