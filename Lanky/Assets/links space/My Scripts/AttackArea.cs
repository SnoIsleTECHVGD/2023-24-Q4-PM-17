using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private int damage = 3;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Health31 health = collider.GetComponent<Health31>();
        if (health != null)
        {
            Debug.Log("you have hit");
            health.Damage(10);
        }

    }
}
