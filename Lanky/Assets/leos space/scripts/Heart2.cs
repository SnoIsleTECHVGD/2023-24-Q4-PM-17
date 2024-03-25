using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Heart2 : Heart1
{

    // Update is called once per frame
    void Update()
    {
        if (health == 40 )
        {
            gameObject.SetActive(false);
        }

        
    }
}
