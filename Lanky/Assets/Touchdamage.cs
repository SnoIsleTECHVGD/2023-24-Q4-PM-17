using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchdamage : MonoBehaviour
{
  
    public GameObject player;
    private Rigidbody2D rb;
   
    
    void Awake()
    {
        //health = player.GetComponent<Health>();
       // player = GameObject.FindGameObjectWithTag("player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        if (collision.gameObject.name == "player")
        {
       //   health.HealthP -= 1;

        }
    }
}

