using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBox : MonoBehaviour


{

    public Health playerHealth;
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Health health = collision.GetComponent<Health>();

        if ( collision.gameObject.CompareTag("player"))
        {
            health.Damage(1);
            playerHealth.Damage(100);
        }
    }
}
