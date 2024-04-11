using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touchdamage : MonoBehaviour
{
    health health;
    public GameObject player;
    private Rigidbody2D rb;
   
    
    void Awake()
    {
        health = player.GetComponent<health>();
        player = GameObject.FindGameObjectWithTag("player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
 
        if (collision.gameObject.name == "player")
        {
       //   health.HealthP -= 1;

        }
    }
}

