using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdespawn : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collision2D collision2D)
    {

        if (collision2D.gameObject.tag == "player")
        {
            Destroy(item);

        }

    }
}
