using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleP1 : MonoBehaviour {

    public float speed = 1.5f;
    public static int scoreP1 = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKey(KeyCode.W) && this.transform.position.y < 4f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 9f);
        }
        else if(Input.GetKey(KeyCode.S) && this.transform.position.y > -4f)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -9f);
        }
        else
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
