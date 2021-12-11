using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScores : MonoBehaviour
{
    public Text highScoreText;
    public Text CoinCount;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");
        CoinCount.text = "Coins: " + PlayerPrefs.GetInt("CoinsTotal");
    }

    private void Update()
    {
        PlayerPrefs.GetInt("CoinsTotal");
    }

    public void setScore()
    {
        if (PlayerPrefs.GetInt("CoinsTotal") <= 0)
        {
            PlayerPrefs.SetInt("CoinsTotal", PlayerPrefs.GetInt("CoinsTotal") * 0);
            CoinCount.text = "Coins: " + PlayerPrefs.GetInt("CoinsTotal");
        }
        else
        {
            PlayerPrefs.SetInt("CoinsTotal", PlayerPrefs.GetInt("CoinsTotal") - 500);
            CoinCount.text = "Coins: " + PlayerPrefs.GetInt("CoinsTotal");
        }
    }
}
