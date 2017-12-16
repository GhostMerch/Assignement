using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleP2 : MonoBehaviour {

    private Ball myBall;
    public static int scoreP2 = 0;
    public static int counter = 0;

    void DontDestroyOnLoad()
    {

    }

    //to make the W & S use if(w is pressed && less then max Height)

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 6f) - 4f;

        float mousePos = Mathf.Clamp(mousePosInUnits, -4f, 4f);

        Vector3 paddlePosition = new Vector3(8f, mousePosInUnits, 0);

        paddlePosition.y = mousePos;

        this.transform.position = paddlePosition;

    }
}