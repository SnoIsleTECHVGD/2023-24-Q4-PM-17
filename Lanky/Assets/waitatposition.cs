using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitatposition : MonoBehaviour
{

    public GameObject PointA;
    public GameObject pointb;
    private Rigidbody2D rb;
    private Animator anima;
    private Transform currentPoint;
    public float speed;


    void Update()
    {
        if ( transform.position.y == -50.965)
        {
            WaitTime();
        }
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == pointb.transform)
        {
            rb.velocity = new Vector2(0, speed);
        }
        else
        {

            rb.velocity = new Vector2(0, -speed);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointb.transform)
        {
            Flip();
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform)
        {
            Flip();
            currentPoint = pointb.transform;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
        currentPoint = pointb.transform;
        anima.SetBool("isRunning", true);
    }


    private IEnumerator WaitTime()
    {
        System.Threading.Thread.Sleep(7000);
        yield return WaitTime();
    }
    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(PointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointb.transform.position, 0.5f);

        Gizmos.DrawLine(pointb.transform.position, PointA.transform.position);
    }
}
