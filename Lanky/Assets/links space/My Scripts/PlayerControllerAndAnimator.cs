using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
//using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerControllerAndAnimator : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool moveInput;

    public static bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime = 0.1f;
    private bool isJumping;
    private bool doubleJump;
    private bool isfacingRight = true;

    public int extraJumps;

    private bool isAttacking = false;
    public GameObject attackArea;
    private float timeToAttack = 0.25f;
    private float timer = 0f;

    private float landCount;
    private bool canLand = false;

    public GameObject player;
    private float velocity;
    private bool wasGrounded;
    
    

    private Animator anim;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponentInParent<Rigidbody2D>();
       

        
    }

    private void Update()
    {
        
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if(isGrounded != true)
        {
            canLand = true; 
        }
        
        if( isGrounded && !wasGrounded)
        {
            if(canLand)
            {
             canLand = false;
             landCount += 1;
             TumbleCount(landCount);
             StartCoroutine(WaitASec(2.3f));
            
            }
            
        }
     
        wasGrounded = isGrounded;

        if (isGrounded == true && Input.GetKeyDown(KeyCode.W))
        {
            anim.SetTrigger("takeOff");
            isJumping = true;
            jumpTimeCounter = 0.1f;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (isGrounded == true)
        {
            doubleJump = !doubleJump;
            anim.SetBool("isJumping", false);
            extraJumps = 2;
            shield.canShield = true;
            

            
        }
        else
        {
            anim.SetBool("isJumping", true);
           shield.canShield = false;
        }


        if (Input.GetKey(KeyCode.W) && isJumping == true)
        {
            if(jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
                
            }
            else
            {
                isJumping = false;
            }
            
        }

        if (Input.GetKey(KeyCode.W) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps = extraJumps - 1;
        }
        else if(Input.GetKey(KeyCode.W) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            isJumping = false;
            doubleJump = false;
        }


        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        
       

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

        if (isfacingRight == true && moveInput < 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
            Flip();
        }
        else if (isfacingRight == false && moveInput > 0)
        {
            Flip();
            transform.eulerAngles = new Vector2(0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
           anim.SetBool("isAttacking", true);

        }
        
  
        
        else
        {
            anim.SetBool("isAttacking", false);
        }

        if (isAttacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                timer = 0;
                isAttacking = false;
                attackArea.SetActive(isAttacking);
            }
        }




      
    }

    void Flip()
    {
        isfacingRight = !isfacingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    public void Attack()
    {
        isAttacking = true;
        attackArea.SetActive(isAttacking);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
        
    }


    private void TumbleCount (float landcount)
    {
        if(landcount == 3)
        {
            anim.SetBool("CanTumble", true);
            anim.SetBool("isJumping", false);
            anim.SetBool("isRunning", false);

            landCount = 0;
          

        }
      
    }



    IEnumerator WaitASec(float secs)
    {
        
        yield return new WaitForSeconds(secs);
        ResetTumble(landCount);
     
    }
    private void ResetTumble ( float landcount)
    {
        if(landcount == 0)
        {
          
            anim.SetBool("CanTumble", false);
        }
    }

   
}

