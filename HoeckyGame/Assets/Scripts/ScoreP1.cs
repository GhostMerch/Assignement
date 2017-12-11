using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreP1 : MonoBehaviour
{
    private LevelManager myLevelManager;
    public static int scoreP1 = 0;

    //works when Collider is Trigger
    void OnTriggerEnter2D(Collider2D collision)
    {
        scoreP1 += 1;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}