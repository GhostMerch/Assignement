﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    private Ball myBall;

    //to make the W & S use if(w is pressed && less then max Height)

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 6f) - 4f;

        float mousePos = Mathf.Clamp(mousePosInUnits, -3.7f, 4f);

        Vector3 paddlePosition = new Vector3(8f, mousePosInUnits, 0);

        paddlePosition.y = mousePos;

        this.transform.position = paddlePosition;

    }
}