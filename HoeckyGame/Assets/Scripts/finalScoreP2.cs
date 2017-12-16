using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScoreP2 : MonoBehaviour {

    public Text txt;

    // Use this for initialization
    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = PaddleP2.scoreP2.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
