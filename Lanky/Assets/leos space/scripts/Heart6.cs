using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart6 : Heart1
{
  
    void Update()
    {
        if (health == 0)
        {
            gameObject.SetActive(false);
        }
    }
}
