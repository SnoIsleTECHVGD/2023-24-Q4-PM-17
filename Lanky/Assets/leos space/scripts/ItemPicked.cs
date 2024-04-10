using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPicked : MonoBehaviour
{
   static public bool itemObtained;

    public TMPro.TextMeshPro text;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        itemObtained = true;
        gameObject.SetActive(false);
    }
}
