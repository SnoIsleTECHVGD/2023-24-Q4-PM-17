using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health31 : MonoBehaviour
{
   public int health = 45;
 
    private int MAX_HEALTH = 5;
    public bool effectedByFallDamage;
    public int ammountOfFallDamage;
    private GameObject enemy;
    private Vector2 enemyAcceleration;
    private bool maxHeightReached;
    public Health PlayerEnemy;
  

    // Update is called once per frame
    void Update()
    {
        
        if(effectedByFallDamage)
        {
            //FallDamage(ammountOfFallDamage, enemyAcceleration);

        } 
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
       
        
        if( collision.gameObject.tag == "player")
       {
            PlayerEnemy.Damage(1);
            enemy = collision.gameObject;
            enemyAcceleration = enemy.GetComponent<Rigidbody2D>().velocity;
            
       
       }

      
       
    }


   //void FallDamage(int fallDamage, Vector2 fallHeight)
    
        //if (fallHeight.y <= -1 && enemy != null)
        
            //enemy.GetComponent<Health31>().Damage(fallDamage);
            
        

        //if(transform.position.y >= 2.5f && !EnemyIsGrounded.IsGrounded)
        
            //maxHeightReached = true;

              //if(maxHeightReached && EnemyIsGrounded.IsGrounded)
            
               //enemy.GetComponent<Health31>().Damage(5);
               //maxHeightReached = false;
            
            
               

            
                    
        

    

    

}
