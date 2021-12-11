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

    public Text Encouragement;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;

        numberOfCoins = 0;
        scoreAmount = 0;
        Encouragement.text = "";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!gameOver)
        {
            scoreAmount++;
            scoreText.text = "Score: " + scoreAmount;
            coinText.text = "Coins: " + numberOfCoins;
        }
        else if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);

            if (PlayerPrefs.GetInt("HighScore") < scoreAmount)
            {
                PlayerPrefs.SetInt("HighScore", scoreAmount);
            }
            PlayerPrefs.SetInt("CoinsTotal", numberOfCoins + PlayerPrefs.GetInt("CoinsTotal"));

            Encouragement.text = EnouragementStatement();
        }
    }

    private string EnouragementStatement()
    {
        List<string> Dictionary = new List<string> { 
            "You can do better than that.", 
            "Play again, you know you want too.",
            "This is not a game...but it is.. -_-",
            "Play again, or else!",
            "That's ok, you just weren't good enough."
        };
        int generated = 0;
        generated = Random.Range(1,Dictionary.Count);

        return Dictionary[generated];
    }
}
