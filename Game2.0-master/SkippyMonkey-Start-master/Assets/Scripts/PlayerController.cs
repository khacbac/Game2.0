using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
public class PlayerController : MonoBehaviour {

    private static float SCREEN_HALF_WIDTH = 320f;
    private static float SCREEN_HALF_HEIGHT = 512f;

    public float playerRunSpeed;
    public float playerJumpSpeed;

    private Rigidbody2D rgBody;
    private Animator anim;

    private void Start()
    {
        rgBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rgBody.velocity = rgBody.velocity.WithX(playerRunSpeed);

        LeanTouch.OnFingerTap += Jump; 
    }

    private void OnDestroy()
    {
        LeanTouch.OnFingerTap -= Jump;
    }

    // Update is called once per frame
    private void Update () {
        rgBody.velocity = rgBody.velocity.WithX(playerRunSpeed);
        if(transform.position.x > SCREEN_HALF_WIDTH)
        {
            Debug.Log(transform.position.x - 2 * SCREEN_HALF_WIDTH);
            transform.position = transform.position.WithX(
                transform.position.x - 2 * SCREEN_HALF_WIDTH);
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

}
