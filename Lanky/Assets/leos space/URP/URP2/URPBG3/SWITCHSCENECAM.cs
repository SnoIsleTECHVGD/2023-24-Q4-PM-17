using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SWITCHSCENECAM : MonoBehaviour
{

    private bool inPortal = false;
    public GameObject [] worldCams;
    public GameObject newSign;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        inPortal = true;

        if ( inPortal == true && CompareTag("portal1"))
        {
            worldCams[0].SetActive(false);
            worldCams[1].SetActive(true);
            AudioManager.Instance.MusicPLayer("PUZZLE1");
        }
        if( inPortal == true && CompareTag("portal2"))
        {
            worldCams[0].SetActive(true);
            worldCams[1].SetActive(false);
            AudioManager.Instance.MusicPLayer("FOREST");
            newSign.SetActive(true);
        }
        if (inPortal == true && CompareTag("portal3"))
        {
            worldCams[0].SetActive(false);
            worldCams[2].SetActive(true);
            AudioManager.Instance.MusicPLayer("PUZZLE1");
        }
        if (inPortal == true && CompareTag("portal4"))
        {
            worldCams[0].SetActive(true);
            worldCams[2].SetActive(false);
            AudioManager.Instance.MusicPLayer("FOREST");
        }


    }
   
}
