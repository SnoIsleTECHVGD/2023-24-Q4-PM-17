using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart5 : Heart1
{
  

    // Update is called once per frame
    void Update()
    {
        if (health == 10)
        {
            gameObject.SetActive(false);
        }
    }
}
