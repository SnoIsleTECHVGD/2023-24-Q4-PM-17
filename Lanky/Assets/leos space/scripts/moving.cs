using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    private float speed = 7f;
    private float horizontal;
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
