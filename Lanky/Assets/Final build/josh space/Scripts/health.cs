using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject player;
    public int HealthP;
    public int NumOfHearts;
    public Animator[] hearts;

    void Update()
    {
        if (HealthP <= 0)
        {
            Destroy(player);

            SceneManager.LoadScene("MainDeath");

        }

        if (HealthP > NumOfHearts)
        {
            HealthP = NumOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i  >= HealthP)
            {
                hearts[i].SetBool("HeartOn", true);
            }
            else
            {
                hearts[i].SetBool("HeartOn", false);
            }
       
        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "dmgthing")
            {
                HealthP -= 1;

            }

        }


    internal static void Damage(int damage)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerEnter2D(Collider2D trigger2D)
    {
        if (trigger2D.gameObject.tag == "healthing")
        {

            Debug.Log("you have healed");
            HealthP = NumOfHearts;

        }
    }



}

