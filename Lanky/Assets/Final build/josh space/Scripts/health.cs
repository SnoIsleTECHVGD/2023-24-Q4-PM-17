using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject player;
    public int HealthP = 5;
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

            if (collision.gameObject.tag == "enemy")
            {
            // StartCoroutine(Waittime)(2000);
              HealthP = HealthP - 1;

            }
          if (collision.gameObject.tag == "healthing")
          {

            Debug.Log("you have healed");

            HealthP = NumOfHearts;

          }

    }
  //  private IEnumerator Waittime()
   // {
    //    yield return new WaitForSeconds(2000); 
  //  }
    

    


    public void Damage(int damage)
    {
        HealthP -= damage;
    }

   



}

