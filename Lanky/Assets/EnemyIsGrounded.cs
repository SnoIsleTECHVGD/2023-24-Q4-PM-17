using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIsGrounded : MonoBehaviour
{
    public static bool IsGrounded = false;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
    }

    
}
