using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeControll : MonoBehaviour
{
   public AudioListener audioListener;
    private bool audioOn;



    public void AudioOn()
    {
        audioListener.enabled = true;
    }

    public void AudioOff()
    {
        audioListener.enabled = false;
    }

}
