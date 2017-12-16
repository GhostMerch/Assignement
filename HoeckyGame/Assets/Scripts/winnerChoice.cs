using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winnerChoice : MonoBehaviour {

    public Text txt;

    // Use this for initialization
    void Start () {
        txt = GetComponent<Text>();
        if (PaddleP1.scoreP1 < PaddleP2.scoreP2)
        {
            txt.text = "The winner is Player 2!";
        }
        else if (PaddleP1.scoreP1 > PaddleP2.scoreP2)
        {
            txt.text = "The winner is Player 1!";
        }
        else
        {
            txt.text = "It's a tie!";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
