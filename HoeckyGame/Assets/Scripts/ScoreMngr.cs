using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMngr : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    public int target = 3;

    // Update is called once per frame
    void Update()
    {
        if (PaddleP1.scoreP1 == target || PaddleP2.scoreP2 == target)
        {
            LevelManager.LoadNextLevel();
        }
    }

}