using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreP1txt : MonoBehaviour {

    public Text txt;
    public int score = 0;
    public static bool count = false;

	// Use this for initialization
	void Start () {
        txt = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (count)
        {
            score += 1;
            txt.text = (score).ToString();
            count = false;
        }
    }
}
