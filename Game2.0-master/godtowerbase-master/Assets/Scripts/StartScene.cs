using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

	public void BeginOnClick()
    {
        //SceneManager.LoadScene("Level 1");
        TKSceneManager.ChangeScene("Level 1");
    }
}
