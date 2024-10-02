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
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


 
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
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < NumOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
       
        }

    }
        private void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "dmgthing")
            {
            // StartCoroutine(Waittime)(2000);
            HealthP -= 1;

            }

        }
  //  private IEnumerator Waittime()
   // {
    //    yield return new WaitForSeconds(2000); 
  //  }
    

    


    internal void Damage(int damage)
    {
        
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

