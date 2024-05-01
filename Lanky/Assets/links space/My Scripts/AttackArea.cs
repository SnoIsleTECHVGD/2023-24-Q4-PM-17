using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAreap : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<Health>() != null)
        {
            Debug.Log("you have hit");
            health.Damage(10);
        }

    }
}
