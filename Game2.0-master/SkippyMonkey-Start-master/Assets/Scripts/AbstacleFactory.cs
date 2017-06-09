using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstacleFactory : MonoBehaviour {

    public GameObject obstaclePrefab;

    private float start = -230f;

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 5; i++)
        {
            start += 170;
            GameObject newObsacle = Instantiate(
            obstaclePrefab,
            new Vector3(Random.Range(-200,200), start, 0),
            Quaternion.identity); // ko xoay.
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
