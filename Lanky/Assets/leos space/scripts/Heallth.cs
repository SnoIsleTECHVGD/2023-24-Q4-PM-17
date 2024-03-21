using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Heallth : MonoBehaviour
{


    public float health; 
    
    void Update()
    {
        health = 100; 


        if ( health == 0)
        {
            gameObject.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.K))
        {
            health = 0;
        }
    }
}
