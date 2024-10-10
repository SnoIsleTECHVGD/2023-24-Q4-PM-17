using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class zoomTo : MonoBehaviour
{
    // Start is called before the first frame update


    public Camera Cam;
    public GameObject newPosition;
    public float lerpSpeed;
    public camerabounds previousCam;
    private bool newCamOn;
    public Transform target;
    public float smoothSpeed = 2f;
    public Vector3 offset;
    public Vector3 minVal, maxval;
    private bool inPortal;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
       
    }


    private void Update()
    {
         if(newCamOn)
        {
          Cam.transform.position = Vector3.Lerp(Cam.transform.position, newPosition.transform.position, lerpSpeed * Time.deltaTime);


        }


           //if(Vector2.Distance(Cam.transform.position,newPosition.transform.position) <= 0.1f)
        {
            //newCamOn = false;
           // previousCam.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("player"))
        {
            previousCam.enabled = false;
            newCamOn = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        
            previousCam.enabled = true;
            newCamOn = false;

        
    }




    void Bounds()
    {
        Vector3 Playerpos = target.position + offset;
        Vector3 boundedPos = new Vector3(Mathf.Clamp(Playerpos.x, minVal.x, maxval.x), Mathf.Clamp(Playerpos.y, minVal.y, maxval.y), Mathf.Clamp(Playerpos.z, minVal.z, maxval.z));

        Vector3 smoothPos = Vector3.Lerp(transform.position, boundedPos, smoothSpeed * Time.fixedDeltaTime);
        transform.position = smoothPos;


    }
}
