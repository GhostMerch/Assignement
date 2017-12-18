using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle1Pos : MonoBehaviour {

    private void Awake()
    {
        Vector2 loc = new Vector2(-8.3f, 0.05f);
        this.transform.position = loc;
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
