using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class boxButton : MonoBehaviour
{
    public Rigidbody2D buttonRB;
    public Transform wall;



    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Crate"))
        {
            GetComponent<Light2D>().enabled = true;  
            buttonRB.constraints = RigidbodyConstraints2D.FreezeRotation;
        }


    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }

}
