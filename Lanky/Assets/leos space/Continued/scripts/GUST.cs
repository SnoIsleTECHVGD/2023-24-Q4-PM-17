using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Rendering;
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
    private Vector2 mousePosition;

    private Rigidbody2D rb;
    private float gustSpeed = 3f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonUp(0) && lowGustActivated)
        {
            LowGust();
        }
        GustController();

        //if (Input.GetMouseButtonUp(0) && midGustActivated)
        {
            //MidGust();
        }
        //if (Input.GetMouseButtonUp(0) && highGustActivated)
        {
            //HighGust();
        }
    }


    void GustController()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0) && !lowGustActivated)
        {
            if(currentGust != null)
            {
                StopCoroutine(currentGust);
            }

           
            currentGust = StartCoroutine(LowGustTimer(3)); 

        }
        
       // if (Input.GetMouseButtonDown(0) && lowGustActivated)
        {
            //if(currentGust != null)
            {
                //StopCoroutine(currentGust);

            }
           
            //StartCoroutine(MidGustTime(2));
        }

        //if (Input.GetMouseButtonUp(0) && midGustActivated)
        {
            //if( currentGust != null)
            {
              //  StopCoroutine(HighGustTime(2));
            }
            //Debug.Log("HIGH GUST! ACTIVATED");
            
           // StartCoroutine(HighGustTime(3));
           // highGustActivated = false;
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (currentGust != null)
            {
                StopCoroutine(currentGust);
                currentGust = null;
            }

            NeautralizeGust();
            BaseGust();

        }

    }




    IEnumerator LowGustTimer(float secs)
    {
       
        yield return new WaitForSeconds(secs);
        Debug.Log("low gust, ACTIVATED");
        lowGustActivated = true;


    }

   // IEnumerator MidGustTime(float secs)
    //{
        //yield return new WaitForSeconds(secs);
       // Debug.Log("mid gust, ACTIVATED");
        //lowGustActivated = false;
       // midGustActivated = true;
   // }

    //IEnumerator HighGustTime(float secs)
    //{
       // yield return new WaitForSeconds(secs);
        //Debug.Log("HIGH gust, ACTIVATED");
        //midGustActivated = false; 
       // highGustActivated = true;
    //}


    void LowGust()
    {


      
        Instantiate(gustPrefabs[1], pinWheelPosition.transform.position, transform.rotation);
        gustPrefabs[1].transform.position = new Vector3(0, 0, 0);
    }

    void BaseGust ()
    {
        Instantiate(gustPrefabs[0], pinWheelPosition.transform.position, transform.rotation);

        gustPrefabs[0].transform.position = new Vector3(0, 0, 0);
    }


    //void MidGust()
    //{
        //Instantiate(gustPrefabs[2], pinWheelPosition.transform.position, transform.rotation);
    //}
    //void HighGust()
    //{
    //    //Instantiate(gustPrefabs[3], pinWheelPosition.transform.position, transform.rotation);
    //}


    void NeautralizeGust()
    {
        lowGustActivated = false;
        midGustActivated = false;
        highGustActivated = false;
    }

}







