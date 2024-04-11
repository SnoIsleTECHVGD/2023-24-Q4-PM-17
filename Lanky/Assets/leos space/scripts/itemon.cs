using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class itemon : MonoBehaviour
{
    public bool itemOn = false;
    [SerializeField] GameObject pin1;
    [SerializeField] GameObject pin2;
    [SerializeField] GameObject pin3;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        itemOn = true;
      
        if (itemOn && pin1.CompareTag("pin1"))
        {
            pin1.gameObject.SetActive(true);

        }
        if (itemOn && pin2.CompareTag("pin2"))
        {
            pin2.gameObject.SetActive(true);

        }
        if (itemOn && pin3.CompareTag("pin3"))
        {
            pin3.gameObject.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        itemOn = false;
    }

    private void Update()
    {
      

    }
    



}







