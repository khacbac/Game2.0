﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Lean.Touch;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour {
    private static float SCREEN_HALF_WIDTH = 320f;

    public float playerRunSpeed;
    public float playerJumpSpeed;

    private Rigidbody2D rgBody;
    private Animator anim;

    private int highScore;
    private int score;

    private GameManagerBehavior gameManager;

    private List<int> listScore = new List<int>();

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HIGH_SCORE", 0);

        rgBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //Vector2 oldVelocity = rgBody.velocity;
        //oldVelocity.x = playerSpeedX;
        //rgBody.velocity = oldVelocity;

        // Functional Programming
        rgBody.velocity = rgBody.velocity.WithX(playerRunSpeed);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();

        LeanTouch.OnFingerTap += Jump;
    }

    private void OnDestroy()
    {
        LeanTouch.OnFingerTap -= Jump;
    }

    private void Update()
    {
        rgBody.velocity = rgBody.velocity.WithX(playerRunSpeed);

        if(transform.position.x > SCREEN_HALF_WIDTH)
        {
            transform.position = transform.position.WithX(
                transform.position.x - 2 * SCREEN_HALF_WIDTH
            );
        }
    }

    private void Jump(LeanFinger finger)
    {
        rgBody.velocity = rgBody.velocity.WithY(playerJumpSpeed);
        anim.SetBool("IsGrounded", false);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("IsGrounded", true);
    }

    public void Die()
    {
        //listScore.Add(gameManager.Score);
        //PlayerPrefs.SetInt("LIST_SCORE_COUNT", listScore.Count);
        //for(int i = 0; i < listScore.Count; i++)
        //{
        //    PlayerPrefs.SetInt("SCORE" + i, gameManager.Score);
        //}
        score = gameManager.Score;
        PlayerPrefs.SetInt("SCORE", score);
        if(score > highScore)
        {
            PlayerPrefs.SetInt("HIGH_SCORE", score);
        }
        SceneManager.LoadScene("GameOverScene");
    }

}
