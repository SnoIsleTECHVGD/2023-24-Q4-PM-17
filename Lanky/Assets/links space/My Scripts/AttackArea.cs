using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreap : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D trigger2D)
    {
        if (trigger2D.gameObject.tag == "enemy" && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("you have hit");
        } 
        
    }
}
