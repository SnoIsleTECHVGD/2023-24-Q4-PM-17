using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicked : MonoBehaviour
{
    private bool MouuseIsHovering = false;

    public GameObject[] onOff;
    public SphereCollider Button;
    private bool inebewteenActive;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MouuseIsHovering && Input.GetMouseButtonDown(0) && bouncePad.playerOnPlat)
        {
            bouncePad.buttonPressed = true;

            onOff[0].SetActive(false);
            onOff[1].SetActive(true);
           
            StartCoroutine(ReturnColor(3));

        }
        if(MouuseIsHovering && Input.GetMouseButtonDown(0) && !bouncePad.playerOnPlat)
        {
            bouncePad.buttonPressed = true;
            onOff[0].SetActive(false);
            onOff[1].SetActive(false);
            onOff[2].SetActive(true);
            inebewteenActive = true;




        }
        if(bouncePad.hasLaunched)
        {
            StartCoroutine(ReturnColor(3));
        }
        if(bouncePad.hasLaunched && inebewteenActive)
        {
            onOff[1].SetActive(true);
            onOff[0].SetActive(false);
        }
        
      
    }


    private void OnMouseEnter()
    {
            Debug.Log("Mouse is over the object!");
        MouuseIsHovering = true;
    }

    private void OnMouseExit()
    {
        MouuseIsHovering = false;
       
    }



    IEnumerator ReturnColor(float secs)
    {
        
        yield return new WaitForSeconds(secs);
        onOff[0].SetActive(true);
        onOff[1].SetActive(false);
        onOff[2].SetActive(false);
        inebewteenActive = false;


    }
}
