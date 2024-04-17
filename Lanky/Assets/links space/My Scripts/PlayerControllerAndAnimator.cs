using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerAndAnimator : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = moveInput.GetAxisRaw("Horiontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }
}
