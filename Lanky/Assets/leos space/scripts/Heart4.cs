using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart4 : Heart1
{
   

  
    void Update()
    {
        if (health == 20)
        {
            gameObject.SetActive(false);
        }
    }
}
