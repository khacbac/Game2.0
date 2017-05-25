using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GateKeeper : MonoBehaviour {

    public string levelNumber;
    public string password;
    public Image image;
    private bool check = true;

    public Text levelText;
    public InputField passwordInput;
    public Text accessDeniedText;

    // Update is called once per frame
    void Update () {
		if(Time.timeSinceLevelLoad % 2 < 1)
        {
            levelText.text = "LEVELS";
        }
        else
        {
            levelText.text = levelNumber;
        }

        if (Input.GetKey(KeyCode.Return))
        {
            submitButtonOnclick();
        }

    }

    public void submitButtonOnclick()
    {
        if(string.IsNullOrEmpty(passwordInput.text.Trim()))
        {
            return;
        }
        if(password == passwordInput.text)
        {
            switch (levelNumber)
            {
                case "1":
                    TKSceneManager.ChangeScene("Level 2");
                    break;
                case "2":
                    TKSceneManager.ChangeScene("Level 3A");
                    break;
                case "3":
                    TKSceneManager.ChangeScene("Level 4A");
                    break;
            }
        }
        else
        {
            passwordInput.text = "";
            accessDeniedText.gameObject.SetActive(true);
        }
    }

    public void nextIconClick()
    {
        switch (levelNumber)
        {
            case "3":
                SceneManager.LoadScene("Level 3B");
                break;
            case "4":
                SceneManager.LoadScene("Level 4B");
                break;
        }
        
    }

    public void backIconClick()
    {
        switch (levelNumber)
        {
            case "3":
                SceneManager.LoadScene("Level 3A");
                break;
            case "4":
                SceneManager.LoadScene("Level 4A");
                break;
        }
    }
}
