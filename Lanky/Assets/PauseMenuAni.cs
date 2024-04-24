using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuAni : MonoBehaviour
{
    private bool close;
    private bool open;
    

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            open = true;
            close = false;
        }
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            close = true;
            open = false;
        }
    }
}
