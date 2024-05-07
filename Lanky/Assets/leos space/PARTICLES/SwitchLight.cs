using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public GameObject[] lights;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        lights[0].SetActive(false);
        lights[1].SetActive(true);
    }
}
