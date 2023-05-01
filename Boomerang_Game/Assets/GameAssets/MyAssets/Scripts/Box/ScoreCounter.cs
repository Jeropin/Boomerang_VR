using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public int score;
    public int highScore;

    public void scoreIncrease(){
        score++;
    }

    public void setHighScore(){
        if(score > highScore){
            highScore = score;
        }
    }
    void restart(){
        score = 0;
    }

    void Start(){
        score = 0;
        highScore = 0;
    }

    void Update(){
        Debug.Log(score);
    }
}
