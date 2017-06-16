using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public Text scoreText;

    private int score;

    private void Start()
    {
        score = PlayerPrefs.GetInt("SCORE");
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
