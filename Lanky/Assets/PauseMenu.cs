using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject [] menuUI;
    
  
  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePaused)
            {
                Resume();
            } 
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
        menuUI[0].SetActive(false);
        menuUI[1].SetActive(false);
        menuUI[2].SetActive(false);
        menuUI[3].SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        menuUI[0].SetActive(true);
        
      
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Leaving Game......");
    }
   
}
