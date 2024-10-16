using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyNumberTwo : MonoBehaviour
{


    public GameObject KEY;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Debug.Log("keyObtained!");
            openWithKey.KeyObtained = true;

        }

        KEY.SetActive(false);
        
    }
}
