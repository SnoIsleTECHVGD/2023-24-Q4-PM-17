using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class bouncePad : MonoBehaviour
{
    public static bool buttonPressed;
    public Rigidbody2D playerRB;
    public Vector2 launchPower;
    public static bool playerOnPlat;
    private Vector2 initialPlatPosition;
    public Transform extensionPoint;
    public static bool hasLaunched;

 
    void Start()
    {
        initialPlatPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(buttonPressed && playerOnPlat)
        {
            transform.position = Vector2.MoveTowards(transform.position, extensionPoint.position, 3 * Time.deltaTime);
            Launch();
            StartCoroutine(returnPosition(3));
           
        }
    

    }




    void Launch()
    {
      

        playerRB.AddForce(launchPower, ForceMode2D.Impulse);
        hasLaunched = true;

    }


    IEnumerator returnPosition(float secs)
    {
        buttonPressed = false;
        yield return new WaitForSeconds(secs);

        while(transform.position.y > initialPlatPosition.y)
        {
            transform.position = Vector2.MoveTowards(transform.position, initialPlatPosition, 3 * Time.deltaTime);
            yield return null;
        }

        initialPlatPosition = transform.position;
        hasLaunched = false;
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {

        playerOnPlat = true;
        }
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {

          playerOnPlat = false;
        }
        
        
        
    }

}
