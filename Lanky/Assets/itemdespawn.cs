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
    private void OnTriggerEnter2D(Collider2D trigger2D)
    {
        if (trigger2D.gameObject.tag == "player")
        {
           
            Debug.Log("you have healed");
            Destroy(gameObject);

        }
    }
}
