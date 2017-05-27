using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GateKeeper : MonoBehaviour
{

    public string levelNumber;
    public string password;
    public string nextSceneName;
    private bool check = true;

    public Text levelText;
    public InputField passwordInput;
    public Text accessDeniedText;
    public Button btnIconNext;

    public List<GameObject> hints;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad % 2 < 1)
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
        if (string.IsNullOrEmpty(passwordInput.text.Trim()))
        {
            return;
        }
        if (password == passwordInput.text)
        {
            TKSceneManager.ChangeScene(nextSceneName);
        }
        else
        {
            passwordInput.text = "";
            accessDeniedText.gameObject.SetActive(true);
        }
    }

    public void changeToSuggestion()
    {
        if (check)
        {
            hints[1].gameObject.SetActive(true);
            hints[0].gameObject.SetActive(false);
            btnIconNext.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else
        {
            hints[1].gameObject.SetActive(false);
            hints[0].gameObject.SetActive(true);
            btnIconNext.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        check = !check;

    }

}
