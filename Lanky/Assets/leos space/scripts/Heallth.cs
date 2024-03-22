using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Heallth : MonoBehaviour
{


    public static float health = 100; 
    
    void Update()
    {
       


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
