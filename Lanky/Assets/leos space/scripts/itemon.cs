using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class itemon : MonoBehaviour
{
    public static bool itemOn;
    [SerializeField] GameObject pin1;
    [SerializeField] GameObject pin2;
    [SerializeField] GameObject pin3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        itemOn = true;
    }

    private void Update()
    {
        if (itemOn)
        {
            pin1.gameObject.SetActive(true);
            pin2.gameObject.SetActive(true);
            pin3.gameObject.SetActive(true);
        }
    }




}







