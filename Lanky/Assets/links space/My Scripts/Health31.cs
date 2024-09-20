using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health31 : MonoBehaviour
{
    [SerializeField] private int health = 100;
 
    private int MAX_HEALTH = 100;

    // Update is called once per frame
    void Update()
    {
      
    }

    public  void Damage(int amount)
    {
        if(amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cant have negative damage");
        }

        this.health -= amount;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Dead X _ X");
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if( collision.gameObject.tag == "Enemy")
       {
            if(collision.gameObject.tag == "shield")
            {
                Damage(0);
            }
            else
            {
                Damage(10);
            }
       
       }
    }

}
