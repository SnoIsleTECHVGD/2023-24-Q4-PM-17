using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bullet;
    public Transform bulletpos;
    public float distance;
    public float distanceBetween = 3f;
    private float timer;
    public GameObject player;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Vector2 direction = (player.transform.position - FirePoint.position).normalized;



        rb.AddForce(direction, ForceMode2D.Impulse);



    }
}
    
