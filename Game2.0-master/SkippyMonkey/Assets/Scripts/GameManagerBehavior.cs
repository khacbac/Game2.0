using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour {

    private int score;
    public Text scoreLabel;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
            scoreLabel.GetComponent<Text>().text = ""+score; 
        }
    }

    private void Start()
    {
        Score = 0;
    }
}
