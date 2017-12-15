using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMngr : MonoBehaviour {



    //works when Collider is Trigger
    //void OnTriggerEnter2D(Collider2D collision)
    //{
    //    scoreP1 += 1;
    //}

    // Use this for initialization
    void Start()
    {

    }

    public int target = 3;

    // Update is called once per frame
    void Update()
    {
        if (PaddleP1.scoreP1 == target)
        {
            LevelManager.LoadNextLevel();
        }
    }

}