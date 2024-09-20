using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public GameObject theShield;
    private float velocity;
    public static bool canShield = false;
    public PlayerControllerAndAnimator movement;
    public static bool isShielding = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theShield.transform.position = new Vector3(transform.localPosition.x,transform.localPosition.y,transform.localPosition.z);
       
       

    }

    private void FixedUpdate()
    {
      

        if (Input.GetKeyDown(KeyCode.F) && canShield)
        {
            theShield.SetActive(true);
            isShielding = true;
            movement.GetComponent<PlayerControllerAndAnimator>().enabled = false;
            theShield.GetComponent<Health31>().enabled = false;
        }

        if(Input.GetKeyUp(KeyCode.F) && isShielding)
        {
            theShield.SetActive(false);
            movement.GetComponent<PlayerControllerAndAnimator>().enabled = true;
            isShielding = false;
        }


        //if(Input.GetKeyDown(KeyCode.F) && !shieldUp)
        {
            //movement.SetActive(false);
        }
    }



}
