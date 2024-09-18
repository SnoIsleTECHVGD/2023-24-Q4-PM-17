using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public GameObject player;
    private bool isfacingRight;
    private float velocity;
    public static bool shieldUp = true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.localPosition.x, player.transform.localPosition.y,player.transform.localPosition.z);

       
    }

    private void FixedUpdate()
    {
        velocity = player.GetComponent<Rigidbody2D>().velocity.x;

        if (Input.GetKeyDown(KeyCode.F) && !shieldUp)
        {
            velocity = 0;
        }
    }



}
