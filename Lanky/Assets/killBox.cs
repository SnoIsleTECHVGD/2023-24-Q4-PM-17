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
            playerHealth.Damage(100);
        }
    }
}
