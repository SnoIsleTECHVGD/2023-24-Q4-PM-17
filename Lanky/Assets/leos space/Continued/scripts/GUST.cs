using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Principal;
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
    private GameObject manipulatedGust;

    private Rigidbody2D rb;
    private static float gustSpeed = 4f;
    public static List<GameObject> previousGust = new List<GameObject>();
    public Animator gust;
    public Animator X;
    public Animator SUCCESS;
    private bool baseGustOn;

   
    
    
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0) && !lowGustActivated)
        {
            X.SetBool("incomplete",true);
            StartCoroutine(ResetAni());
        }



        if (Input.GetMouseButtonUp(0) && lowGustActivated)
        {
           
            gust.SetBool("isCharging", false);
            gust.SetBool("Charged", false);
            gust.SetBool("Returned", true);
            SUCCESS.SetBool("complete", true);
            LowGust();
            StartCoroutine(ResetAni());
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


    private void GustController()
    {
        
        if (Input.GetMouseButtonDown(0) && !lowGustActivated)
        {
            gust.SetBool("isCharging", true);
            
            if(currentGust != null)
            {
                StopCoroutine(currentGust);
            }

            //1.566605 1.354069 -0.06 -0.08
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
                gust.SetBool("isCharging", false);
                //X.SetBool("incomplete", true);
                //StartCoroutine(ResetAni());
            }

            NeautralizeGust();
            BaseGust();
            

        }

    }




    IEnumerator LowGustTimer(float secs)
    {
       
        yield return new WaitForSeconds(secs);
        gust.SetBool("Charged", true);
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


   public void LowGust()
    {


       
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        manipulatedGust = Instantiate(gustPrefabs[1], pinWheelPosition.transform.position, Quaternion.identity);
        previousGust.Add(manipulatedGust);
        StartCoroutine(GustMovement(manipulatedGust, mousePosition));

    }

   public void BaseGust ()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        manipulatedGust = Instantiate(gustPrefabs[0], pinWheelPosition.transform.position, Quaternion.identity);
        previousGust.Add(manipulatedGust);
        StartCoroutine(GustMovement(manipulatedGust, mousePosition));
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

    IEnumerator GustMovement ( GameObject Gust, Vector2 target)
    {
       
        Vector2 currentVelocity = Vector2.zero;
        

        while (Vector2.Distance(Gust.transform.position, target) > 0.1f)
        {


            Gust.transform.position = Vector2.SmoothDamp(Gust.transform.position, target, ref currentVelocity, 0.3f);

            yield return null;


        }

        yield return new WaitForSeconds(3.5f);
        Gust.transform.position = target;

        Destroy(Gust);

    }


    IEnumerator ResetAni ()
    {
        yield return new WaitForSeconds(1f);
        X.SetBool("incomplete",false);
        SUCCESS.SetBool("complete",false);
    }
}







