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
}
