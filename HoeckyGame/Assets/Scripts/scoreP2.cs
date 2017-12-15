using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreP2 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        PaddleP1.scoreP1 += 1;
        Debug.Log("Player 1's score: " + PaddleP1.scoreP1);
        Ball.hasStarted = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
