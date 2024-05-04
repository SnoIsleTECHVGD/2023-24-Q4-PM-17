using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWITCHSCENECAM : MonoBehaviour
{

    private bool inPortal = false;
    public GameObject [] worldCams;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        inPortal = true;

        if ( inPortal == true )
        {
            worldCams[0].SetActive(false);
            worldCams[1].SetActive(true);
        }
    }
}
