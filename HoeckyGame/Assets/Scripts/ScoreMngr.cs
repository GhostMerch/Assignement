using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMngr : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if(PaddleP1.levelNum < 3){
            PaddleP1.levelNum += 1;
        }
        Debug.Log(target);
        PaddleP1.counter = 0;
        PaddleP2.counter = 0;
    }

    private static int[] targetScore = {3,7,10};
    private int target = targetScore[(PaddleP1.levelNum)];
    //(SceneManager.GetActiveScene().buildIndex-1)

    // Update is called once per frame
    void Update()
    {
        if (PaddleP1.counter == target || PaddleP2.counter == target)
        {
            LevelManager.LoadNextLevel();
        }
    }

}