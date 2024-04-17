using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{

    private Rigidbody2D rb;

    public int HealthP ;
    public int NumOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyheart;

    void Update()
    {

        if(HealthP > NumOfHearts)
        {
            HealthP = NumOfHearts;
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < HealthP)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyheart;
            }
            if(i< NumOfHearts)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false; 
            }
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
