using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapearfre : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
