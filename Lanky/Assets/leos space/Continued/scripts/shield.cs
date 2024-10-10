using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public Health31 disableHealth;
    public GameObject theShield;
    public static bool canShield = false;
    public PlayerControllerAndAnimator movement;
    public static bool isShielding = false;
    public Animator shieldani;
    public Rigidbody2D velocity;
    public Animator playerAni;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) && canShield)
        {
         theShield.transform.position = new Vector2(transform.position.x, transform.position.y);

            playerAni.SetBool("isRunning", false);
            theShield.SetActive(true);
            shieldani.SetBool("isShielding",true);
            isShielding = true;
            disableHealth.GetComponent<Health31>().enabled = false;
            velocity.velocity = new Vector2(0,0);
            movement.GetComponent<PlayerControllerAndAnimator>().enabled = false;
            
        }

        if (Input.GetKeyUp(KeyCode.F) && isShielding)
        {
          StartCoroutine(ExitShield(0.4f));
        }



    }

    private void FixedUpdate()
    {
      

       


        //if(Input.GetKeyDown(KeyCode.F) && !shieldUp)
        {
            //movement.SetActive(false);
        }
    }



    IEnumerator ExitShield (float secs)
    {
        shieldani.SetBool("isShielding", false);
        shieldani.SetBool("shieldPopped", true);
        yield return new WaitForSeconds(secs);
        theShield.SetActive(false);
        disableHealth.GetComponent<Health31>().enabled = true;
        movement.GetComponent<PlayerControllerAndAnimator>().enabled = true;
        isShielding = false;

    }
   

}
