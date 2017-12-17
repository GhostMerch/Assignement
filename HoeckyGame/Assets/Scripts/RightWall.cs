using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWall : MonoBehaviour {

    public float min;
    public float max;

    // Use this for initialization
    void Start () {
        min = transform.position.x -3;
        max = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time * 2, max - min) + min);
    }
}
