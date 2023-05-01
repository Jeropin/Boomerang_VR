using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartHandler : MonoBehaviour
{
    public GameObject rang;
    public GameObject spawner;
    public GameObject welcomeMenu;
    public GameObject restartMenu;
    public GameObject resultsMenu;
    public GameObject timer;
    public GameObject ScoreCounter;
    public ResultsHandler results;
    public bool destroy = false;
    
    public void restart(){

        rang.GetComponent<Transform>().position = new Vector3(0.5f, -0.5f, 0);
        
        spawner.SetActive(false);

        timer.GetComponent<TimerHandler>().timeDuration = 1f * 60f;
        timer.SetActive(false);

        resultsMenu.SetActive(false);
        // restartMenu.SetActive(false);

        ScoreCounter.GetComponent<ScoreCounter>().score = 0;

        welcomeMenu.SetActive(true);
    }

    void destroyAll(){
        GameObject[] enemies =GameObject.FindGameObjectsWithTag("Enemy");
        for(int i=0; i< enemies.Length; i++)
        {
            GameObject.Destroy(enemies[i]);
        }
    }

    void Update(){
        if(timer.GetComponent<TimerHandler>().timeDuration <= 0){
            destroyAll();
            resultsMenu.SetActive(true);
            // private ResultsHandler results;
            results.setScore();
            
        }
    }
}
