using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour {

    public Button playButton;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnImageStartClick()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnHighScoreButtonClick()
    {
        SceneManager.LoadScene("HighScoreScene");
    }
}
