using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Heart1 : MonoBehaviour
{


    public static float health = 60;
    

    void Update()
    {
       


        if ( health == 50 )
        {
            gameObject.SetActive(false);
        }

    }
}
