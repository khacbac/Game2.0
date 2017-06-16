using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BananaController : MonoBehaviour {


    public GameObject bananaGameObject;

    private GameManagerBehavior gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

    

    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Head")
        {
            gameManager.Score += 1;
        }
    }

    
}
