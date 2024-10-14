using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLatform : MonoBehaviour
{
    public GameObject PointA;
    public GameObject pointb;
    private Rigidbody2D rb;
    private Animator anima;
    private Transform currentPoint;
    public float speed;
    public bool reachedPoint = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //anima = GetComponent<Animator>();
        currentPoint = pointb.transform;
        //anima.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 point = currentPoint.position - transform.position;

       //if(!reachedPoint)
        {

         //transform.position = Vector3.Lerp(transform.position, PointA.transform.position, speed);

        }
  
        //if(Vector3.Distance(transform.position,PointA.transform.position) <= 0.1)
        {
           // reachedPoint = true;
           // StartCoroutine(WaitTime(8));
        }

        if (currentPoint == pointb.transform)
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, speed);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointb.transform)
        {
           
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform)
        {
           
            currentPoint = pointb.transform;
        }

    }
   
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(PointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointb.transform.position, 0.5f);

        Gizmos.DrawLine(pointb.transform.position, PointA.transform.position);
    }



   IEnumerator WaitTimeA(float secs)
    {
        yield return new WaitForSeconds(secs);
        currentPoint = PointA.transform;


    }


    IEnumerator WaitTimeB(float secs)
    {
        yield return new WaitForSeconds(secs);
        currentPoint = pointb.transform;
    }


    

}

