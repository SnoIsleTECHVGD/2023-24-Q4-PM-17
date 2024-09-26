using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    private Coroutine currentGust;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GustController();
        
        if( Input.GetMouseButtonUp(0) && lowGustActivated)
        {
            LowGust();
        }
        if (Input.GetMouseButtonUp(0) && midGustActivated)
        {
            MidGust();
        }
        if (Input.GetMouseButtonUp(0) && highGustActivated)
        {
            HighGust();
        }

    }

    void GustController()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(currentGust != null)
            {
                StopCoroutine(currentGust);
            }

           
            currentGust = StartCoroutine(LowGustTimer(3)); 
          
        }
        
        if(Input.GetMouseButtonUp(0))
        {
            if(currentGust != null)
            {
                StopCoroutine(currentGust);
                currentGust = null;
            }

            NeautralizeGust();
            BaseGust();
            return;
        }

        if (Input.GetMouseButtonDown(0) && lowGustActivated)
        {
            if(currentGust != null)
            {
                StopCoroutine(currentGust);
            }
 
            
            StartCoroutine(MidGustTime(2));
        }

        if (Input.GetMouseButton(0) && midGustActivated)
        {
            if( currentGust != null)
            {
                StopCoroutine(HighGustTime(2));
            }
            Debug.Log("HIGH GUST! ACTIVATED");
            
            StartCoroutine(HighGustTime(3));
            highGustActivated = false;
            
        }

    }

    
    
    
    IEnumerator LowGustTimer(float secs)
    {
       
        yield return new WaitForSeconds(secs);
        Debug.Log("low gust, ACTIVATED");
        lowGustActivated = true;


    }

    IEnumerator MidGustTime(float secs)
    {
        yield return new WaitForSeconds(secs);
        Debug.Log("mid gust, ACTIVATED");
        lowGustActivated = false;
        midGustActivated = true;
    }

    IEnumerator HighGustTime(float secs)
    {
        yield return new WaitForSeconds(secs);
        Debug.Log("HIGH gust, ACTIVATED");
        midGustActivated = false; 
        highGustActivated = true;
    }


    void LowGust()
    {
        Instantiate(gustPrefabs[1], pinWheelPosition.transform.position, transform.rotation);
    }

    void BaseGust ()
    {
        Instantiate(gustPrefabs[0], pinWheelPosition.transform.position, transform.rotation);
    }


    void MidGust()
    {
        Instantiate(gustPrefabs[2], pinWheelPosition.transform.position, transform.rotation);
    }
    void HighGust()
    {
        Instantiate(gustPrefabs[3], pinWheelPosition.transform.position, transform.rotation);
    }


    void NeautralizeGust()
    {
        lowGustActivated = false;
        midGustActivated = false;
        highGustActivated = false;
    }

}







