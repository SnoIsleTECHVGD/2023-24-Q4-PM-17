using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour
{

    public GameObject [] Hearts;
    private float health = 60;
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        health -= 10;

        if (health == 50)
        {
            Hearts[0].SetActive(false);
        }
        if (health == 40)
        {
            Hearts[1].SetActive(false);
        }
        if (health == 30)
        {
            Hearts[2].SetActive(false);
        }
        if (health == 20)
        {
            Hearts[3].SetActive(false);
        }
        if (health == 10)
        {
            Hearts[4].SetActive(false);
        }
        if (health == 0)
        {
            Hearts[5].SetActive(false);
        }
    }


}
