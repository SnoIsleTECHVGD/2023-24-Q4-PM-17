using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public Transform endPoint;
    public Transform startingPoint;
    public Transform movingPlatform;
    private bool reachedPlat = false;
    public float speed;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!reachedPlat)
        {

            StartCoroutine(waitTime(5f));
            
            
        }
        
        
        if (reachedPlat)
        {
            
           StartCoroutine(returnTime(5f));
           
        }

      
    }

    IEnumerator waitTime(float waitTime)
    {
        movingPlatform.position = Vector2.MoveTowards(movingPlatform.position, endPoint.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(waitTime);
        reachedPlat = true;
    }

    IEnumerator returnTime (float returnTime)
    {
        Debug.Log("reached endpoint!");
        movingPlatform.position = Vector2.MoveTowards(movingPlatform.position, startingPoint.position, speed * Time.deltaTime);
        yield return new WaitForSeconds(returnTime);
        reachedPlat = false;
    }
}
