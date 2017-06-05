using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstacleFactory : MonoBehaviour {

    public GameObject obstaclePrefab;

	// Use this for initialization
	void Start () {
        GameObject newObsacle = Instantiate(
            obstaclePrefab,
            new Vector3(-200, 200, 0), 
            Quaternion.identity); // ko xoay.
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
