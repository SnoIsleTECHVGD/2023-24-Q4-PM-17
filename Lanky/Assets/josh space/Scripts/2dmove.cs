using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twodmove : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpPower = 16f;
    private bool isfacingRight = true;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private layermask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = input.GetAxisRaw("Horizontal");
    }
    private void FixedUpdate() { }

    private void Flip()
    {
        if (isfacingRight && horizontal , 0f || !isfacingRight && horizontal > 0f){
            isfacingRight = !isfacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= 1f;
            transform.localScale = localScale;
        }
    }
}
