using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bullet;
    public Transform bulletpos;
    public float distance;
    public float distanceBetween;
    private float timer;
    public GameObject player;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Lanky_Character");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();

        if (distance < distanceBetween)
        {
            animator.SetBool("shooting", true);
            timer += Time.deltaTime;
            
            if (timer > 3)
            {
                timer = 0;
               
                shoot();
                
            }
          
        }
        else
        {
            animator.SetBool("shooting", false);
        }



    }
    void shoot()
    {
        
        GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Force);


    }
}
    
