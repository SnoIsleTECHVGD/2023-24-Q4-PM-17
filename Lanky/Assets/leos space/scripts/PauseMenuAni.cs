using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuAni : MonoBehaviour
{
    private bool close = true;
    private bool open = false;
    public Animator pauseAnimator;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && close == true)
        {
            open = true;
            pauseAnimator.SetBool("Open", true);
            pauseAnimator.SetBool("Close", false);
            close = false;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && close == false)
        {
            close = true;
            pauseAnimator.SetBool("Open", false);
            pauseAnimator.SetBool("Close", true);
            open = false;
        }
    }
}
