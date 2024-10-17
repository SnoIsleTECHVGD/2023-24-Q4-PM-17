using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class activatedDoubleJump : MonoBehaviour
{
    public GameObject thisObject;
    public Image bottleUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            PlayerControllerAndAnimator.doubleJumpObtained = true;
            bottleUI.gameObject.SetActive(true);
             thisObject.SetActive(false);
        }
       


    }
}
