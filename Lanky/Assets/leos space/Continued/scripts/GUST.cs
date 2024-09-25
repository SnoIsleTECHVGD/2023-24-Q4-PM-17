using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GUST : MonoBehaviour
{
    private float buttonDownTime;
    private bool lowGustActivated;
    private bool midGustActivated;
    private bool highGustActivated;


    public GameObject pinWheelPosition;
    public GameObject[] gustPrefabs;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GustController();
        
        if(lowGustActivated)
        {
            LowGust();
        }
    }

    void GustController()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(LowGustTimer(3));
        }

        if (Input.GetMouseButtonDown(0) && lowGustActivated)
        {
            StartCoroutine(MidGustTime(5));
        }

        if (Input.GetMouseButton(0) && midGustActivated)
        {
            StartCoroutine(HighGustTime(7));
            highGustActivated = false;
        }

    }

    
    
    
    IEnumerator LowGustTimer(float secs)
    {
        yield return new WaitForSeconds(secs);
        lowGustActivated = true;


    }

    IEnumerator MidGustTime(float secs)
    {
        yield return new WaitForSeconds(secs);
        lowGustActivated = false;
        midGustActivated = true;
    }

    IEnumerator HighGustTime(float secs)
    {
        yield return new WaitForSeconds(secs);
        midGustActivated = false; 
        highGustActivated = true;
    }


    void LowGust()
    {
        Instantiate(gustPrefabs[0], pinWheelPosition.transform.position, transform.rotation);
    }











}
