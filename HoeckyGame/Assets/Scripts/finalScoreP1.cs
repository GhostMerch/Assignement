using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScoreP1 : MonoBehaviour {

    public Text txt;

    // Use this for initialization
    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = PaddleP1.scoreP1.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
