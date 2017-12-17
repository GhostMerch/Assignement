using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PaddleP1.scoreP1 = 0;
        PaddleP2.scoreP2 = 0;
        PaddleP1.counter = 0;
        PaddleP2.counter = 0;
        Debug.Log("Paddle 1 " + PaddleP1.scoreP1);
        Debug.Log("Paddle 1 " + PaddleP1.counter);
        Debug.Log("Paddle 2 " + PaddleP2.scoreP2);
        Debug.Log("Paddle 2 " + PaddleP2.counter);
        PaddleP1.levelNum = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
