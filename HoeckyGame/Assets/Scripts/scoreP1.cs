using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreP1 : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        PaddleP2.scoreP2 += 1;
        Debug.Log("Player 2's score: " + PaddleP2.scoreP2);
        Ball.hasStarted = false;
        scoreP2txt.count = true;
    }

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
