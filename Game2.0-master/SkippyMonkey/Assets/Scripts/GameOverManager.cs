using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;

    private int score;

    private int highScore;

    private List<int> listScore = new List<int>();



    private void Start()
    {
        score = PlayerPrefs.GetInt("SCORE");
        scoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HIGH_SCORE", 0).ToString();
    }

    public void SetOnRetryButtonClick()
    {
        //PlayerPrefs.SetInt("SCORE_SAVE", score);
        TKSceneManager.ChangeScene("PlayScene");
    }

    public void SetOnHomeButtonClick()
    {
        //PlayerPrefs.SetInt("SCORE_SAVE", score);
        TKSceneManager.ChangeScene("StartScene");
    }
}
