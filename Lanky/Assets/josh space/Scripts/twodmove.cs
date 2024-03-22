using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twodmove : MonoBehaviour
{
    private float horizontal;
    public float speed = 8f;
    public float jumpPower = 16f;
    private bool isfacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] public KeyCode jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if( Input.GetKey(jump) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }


        
        Flip();


       if(rb.velocity.y <0)
        {
            rb.gravityScale = rb.gravityScale * 2;

        }
       if( IsGrounded() )
        {
            rb.gravityScale = 1;
        }
    }
    private void FixedUpdate() 
    {
        rb.velocity =  new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position,0.4f,groundLayer);
    }
    private void Flip()
    {
        if (isfacingRight && horizontal < 0f || !isfacingRight && horizontal > 0f){

            isfacingRight = !isfacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }
    }
}
