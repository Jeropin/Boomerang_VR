using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ResultsHandler : MonoBehaviour
{

    public ScoreCounter scoreCounter;
    public TMP_Text score;
    // Start is called before the first frame update
    public void setScore(){
        scoreCounter.setHighScore();  
        score.text = "Score: " + scoreCounter.score + "\n" +
                     "High Score: " + scoreCounter.highScore;
    }


}
