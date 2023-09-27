using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBestScore : MonoBehaviour
{
    public Text bestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        // LOAD HIGH SCORE
        // If you do not load on start, this UI would not know what the high score is
        MainManager.Instance.LoadHighScore();

        Debug.Log("High Score is " + MainManager.Instance.highScore);

        // DISPLAY HIGH SCORE AND PLAYER
        if (MainManager.Instance != null)
        {
            if (MainManager.Instance.highScore != 0)
            {
                DisplayHighScore();
            }
            else
            {
                DisplayName();
            }
        }
        else
        {
            bestScoreText.text = "Hello, set a high score!";
        }
    }

    void DisplayHighScore()
    {
        bestScoreText.text = MainManager.Instance.playerName + ", can you beat the High Score " 
            + MainManager.Instance.highScore + " by " + MainManager.Instance.highScoreName + "?";
    }

    void DisplayName()
    {
        bestScoreText.text = MainManager.Instance.playerName + ", set a High Score!";
    }
}
