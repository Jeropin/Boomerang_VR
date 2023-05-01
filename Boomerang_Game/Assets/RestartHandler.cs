using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartHandler : MonoBehaviour
{
    public GameObject rang;
    public GameObject spawner;
    public GameObject welcomeMenu;
    public GameObject timer;
    public bool destroy = false;
    

    void Start(){
        rang.GetComponent<Transform>().position = new Vector3(0.3f, -0.9f, 0);
        spawner.SetActive(false);
    }
    public void restart(){
        GameObject[] enemies =GameObject.FindGameObjectsWithTag("Enemy");
        for(int i=0; i< enemies.Length; i++)
        {
            GameObject.Destroy(enemies[i]);
        }

        rang.GetComponent<Transform>().position = new Vector3(0.3f, -0.9f, 0);
        spawner.SetActive(false);
    }

    void Update(){
        if(destroy){
            restart();
        }
    }
}
