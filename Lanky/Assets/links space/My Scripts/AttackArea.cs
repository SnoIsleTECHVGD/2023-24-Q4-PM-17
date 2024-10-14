using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 3;
    public static bool isHooked;
    public static GameObject ballAndChainScript;
    public GameObject[] damgeSprite;
    private SpriteRenderer colorFlash;
   




    private void Start()
    {
      
    }





    private void OnTriggerEnter2D(Collider2D collider)
    {

        ballAndChainScript = collider.gameObject;
        Health31 health = collider.GetComponent<Health31>();
        if (health != null)
        {
            //Debug.Log("you have hit");
            health.Damage(10);
            collider.GetComponent<flashWhen>().Flash();




        }
       
        if (Input.GetKey(KeyCode.R) && collider.CompareTag("Enemy"))
        {
           
            isHooked = true;

            
        }
        
        
 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!isHooked)
        {
          ballAndChainScript = null;

        }

    }


   
}


