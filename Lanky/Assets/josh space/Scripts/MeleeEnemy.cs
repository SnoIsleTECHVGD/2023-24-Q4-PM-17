using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public GameObject PointA;
    public Gamebject pointb;
    private Ridgidbody2D rb;
    private Animater anima;
    private Tranform currentPoint;
    public float speed; 
    void Start()
    {
        rb = GetConponent<Ridgidbody2D>();
        anima = GetConponent<Animater>();
        currentPoint = pointb.transform;
        anima.SetBool("isRunning", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if(currentPoint == pointb.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if(Vector2.Distance(transform.position, currentPoint.position) <0.5f && currentPoint == pointb.transform)
        {
            Flip();
            currentPoint = PointA.transform;
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            Flip();
            currentPoint = Pointb.transform;
        }

    }
    private void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    private  void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(pointA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(pointb.transform.position, 0.5f);

        Gizmos.DrawLine(pointb.transform.position, pointA.tranform.position);
    }
}
