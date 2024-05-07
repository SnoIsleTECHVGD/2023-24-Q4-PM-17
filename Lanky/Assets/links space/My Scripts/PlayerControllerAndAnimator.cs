using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerControllerAndAnimator : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    private bool moveInput;

  
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

    private float jumpTimeCounter;
    public float jumpTime = 0.1f;
    private bool isJumping;
    private bool doubleJump = false;
    private bool isfacingRight = true;

    private bool isAttacking = false;
    private GameObject attackArea = default;
    private float timeToAttack = 0.25f;
    private float timer = 0f;


    private Animator anim;
    
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponentInParent<Rigidbody2D>();
        attackArea = transform.GetChild(0).gameObject;
    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            if( isGrounded() || doubleJump)
            {
                AudioManager.Instance.PlaySFX("jump");
                doubleJump = !doubleJump;
                anim.SetTrigger("takeOff");
                isJumping = true;
                jumpTimeCounter = 0.1f;
                rb.velocity = Vector2.up * jumpForce;

            }
        }

        if (isGrounded())
        {
            doubleJump = false;
            anim.SetBool("isJumping", false);
        }

        if(isGrounded() && !Input.GetKeyDown(KeyCode.W))
        {
          
            doubleJump = false; 
        }
       
        else
        {
            anim.SetBool("isJumping", true);
        }
        if ( isGrounded() == false)
        {
            isJumping = true;
        }
        if ( isJumping == true)
        {
            doubleJump = true;
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
            Flip();
            transform.eulerAngles = new Vector2(0, 180);
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

    private void Attack()
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

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
    }
}
