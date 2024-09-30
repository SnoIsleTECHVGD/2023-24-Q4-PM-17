using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIsGrounded : MonoBehaviour
{
    private bool IsGrounded = false;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool maxHeightReached;
    public int impactDamage;


    private bool wasGrounded = true;
    private float maxHeight;

   [SerializeField] public int HeightLimit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);


        FallDamage(impactDamage, HeightLimit);




        //if (maxHeight  >= 2.5f)
        {
            // maxHeightReached = true;
        }

      
        //if (IsGrounded && !wasGrounded)
        {
           
            //if (maxHeightReached)
            {
                //GetComponent<Health31>().Damage(impactDamage);
               // maxHeightReached = false;  
            }
        }

       
        //wasGrounded = IsGrounded;

       
        //if (IsGrounded)
        {
            //maxHeight = transform.position.y;
        }
    
        
        void FallDamage(int fallDamage, int maxHeight)
        {

            if (transform.position.y >= 2.5f && !IsGrounded)
            {
                maxHeightReached = true;

            }


            if (IsGrounded && maxHeightReached)
            {
                maxHeightReached = false;
                GetComponent<Health31>().Damage(fallDamage);


            }

        }



        


    }




}









   
    

      
    
    
    
    




        

    

