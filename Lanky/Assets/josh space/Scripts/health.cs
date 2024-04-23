using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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



        }

        if (HealthP > NumOfHearts)
        {
            HealthP = NumOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i - 1 >= HealthP)
            {
                hearts[i].SetBool("HeartOn", true);
            }
            else
            {
                hearts[i].SetBool("HeartOn", false);
            }
            // the player will need to die when the helath gets to 0
          




        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "dmgthing")
            {
                HealthP -= 1;

            }

            if (collision.gameObject.tag == "healthing")
            {
                HealthP += NumOfHearts;
                Debug.Log("you have healed");

            }
        }

    }

