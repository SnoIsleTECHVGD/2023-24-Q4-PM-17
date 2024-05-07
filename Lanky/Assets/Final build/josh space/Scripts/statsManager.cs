using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsManager : MonoBehaviour
{
    public int health;
    public int attack;
    public void TakeDamage(int amount)
    {
        health -= amount;
    }
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<statsManager>();
        if(atm != null)
        {
            atm.TakeDamage(attack);
        }
    }
}
