using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart3 : Heart1
{
   

  
    void Update()
    {
        if (health == 30)
        {
            gameObject.SetActive(false);
        }
    }
}
