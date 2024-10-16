using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBox : MonoBehaviour


{

    public Health31 playerHealth;
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.CompareTag("player"))
        {
            playerHealth.health = 0;
        }
    }
}
