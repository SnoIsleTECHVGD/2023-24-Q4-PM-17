using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GustCollider : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    public Vector2 blastHight;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            enemyRb = collision.GetComponent<Rigidbody2D>();

            if( enemyRb != null)
            {
                enemyRb.AddForce(blastHight, ForceMode2D.Impulse);
            }
        }
    }
}
