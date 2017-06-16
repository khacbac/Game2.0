using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{

    public Text scoreText;

    private int score;

    private int listScoreCount;

    private void Start()
    {
        listScoreCount = PlayerPrefs.GetInt("LIST_SCORE_COUNT");
        for (int i = 0; i < listScoreCount; i++)
        {
            score = PlayerPrefs.GetInt("SCORE" + i);
        }
        scoreText.text = "" + score;
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
