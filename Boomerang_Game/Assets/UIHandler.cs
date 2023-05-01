using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public bool isMenu = false;
    public GameObject restartMenu;
    public GameObject welcomeMenu;
    public GameObject resultsMenu;

    public void toggleMenu(){

        if(welcomeMenu.activeSelf || resultsMenu.activeSelf){
            return;
        }

        else{
            isMenu = !isMenu;
            restartMenu.SetActive(isMenu);

            if(isMenu){
                pauseGame();
            }

            else{
                resumeGame();
            }
        }
    }

    public void pauseGame(){
        Time.timeScale = 0;
    }

    public void resumeGame(){
        Time.timeScale = 1;
    }
}
