using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.WSA;

public class Activation : MonoBehaviour
{
    public PLatform platform;
    public waitatposition wait;
    public GameObject[] activationLights;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Crate"))
        {
            platform.enabled = true;
            activationLights[0].SetActive(true);
            activationLights[1].SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        activationLights[0].SetActive(false);
        activationLights[1].SetActive(true);
    }
}
