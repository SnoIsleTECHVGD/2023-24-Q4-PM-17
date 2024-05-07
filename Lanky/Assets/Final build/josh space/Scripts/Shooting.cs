using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float nextProjectile = 0.0f;
    public float projectileCoolDown = 1.0f;
    public GameObject playerBullet;
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetButtonDown("Fire1") && Time.time > nextProjectile)
        {
            Shoot();
            nextProjectile = Time.time + projectileCoolDown;
        }
       
    }
    void Shoot( )
    {
       GameObject bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(FirePoint.up * bulletForce, ForceMode2D.Force);
    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if ( collision.gameObject)
        {
            Destroy(gameObject);
        }
    }
}
 
