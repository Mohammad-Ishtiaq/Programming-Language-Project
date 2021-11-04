using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    public static bool gameOver;
    public GameObject gameOverPanel;

    public static int numberOfCoins;
    public Text coinText;

    public static int scoreAmount = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;

        numberOfCoins = 0;
        scoreAmount = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!gameOver)
        {
            scoreAmount++;
            scoreText.text = "Score: " + scoreAmount;
            coinText.text = "Coins: " + numberOfCoins;
        }else if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            if (PlayerPrefs.GetInt("HighScore") < scoreAmount)
            {
                PlayerPrefs.SetInt("HighScore", scoreAmount);
            }
            PlayerPrefs.SetInt("CoinsTotal", numberOfCoins + PlayerPrefs.GetInt("CoinsTotal"));
        }
    }
}
