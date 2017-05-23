using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateKeeper : MonoBehaviour {

    public string levelNumber;
    public string password;
    public string nextSceneName;

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
            nextButtonOnclick();
        }

    }

    public void nextButtonOnclick()
    {
        if(string.IsNullOrEmpty(passwordInput.text.Trim()))
        {
            return;
        }
        if(password == passwordInput.text)
        {
            TKSceneManager.ChangeScene("Level 2");
        }
        else
        {
            passwordInput.text = "";
            accessDeniedText.gameObject.SetActive(true);
        }
    }
}
