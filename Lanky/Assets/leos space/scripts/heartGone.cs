using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartGone : MonoBehaviour
{
   

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Heallth.health = 0;
    }
}
