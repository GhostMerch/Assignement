using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class ScoreMngr : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if(PaddleP1.levelNum < 3){
            PaddleP1.levelNum += 1;
        }
        Debug.Log(target);
    }

    private static int[] targetScore = {3,8,15};
    private int target = targetScore[(PaddleP1.levelNum)];
    //(SceneManager.GetActiveScene().buildIndex-1)

    // Update is called once per frame
    void Update()
    {
        if (PaddleP1.scoreP1 == target || PaddleP2.scoreP2 == target)
        {
            LevelManager.LoadNextLevel();
        }
    }

}