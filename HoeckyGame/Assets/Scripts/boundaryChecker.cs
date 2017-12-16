using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryChecker : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collision)
    {
        Ball.hasStarted = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
