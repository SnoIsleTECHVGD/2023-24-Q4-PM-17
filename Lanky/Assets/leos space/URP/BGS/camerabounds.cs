using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerabounds : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 2f;
    public Vector3 offset;
    public Vector3 minVal, maxval;
    private bool inPortal;
    public GameObject GameObject;
    

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Bounds();
        

        
    }

    void Bounds()
    {
        Vector3 Playerpos = target.position + offset;
        Vector3 boundedPos = new Vector3(Mathf.Clamp(Playerpos.x,minVal.x,maxval.x), 
            Mathf.Clamp(Playerpos.y, minVal.y, maxval.y), 
            Mathf.Clamp(Playerpos.z, minVal.z, maxval.z));
      
        Vector3 smoothPos = Vector3.Lerp(transform.position, boundedPos, smoothSpeed * Time.fixedDeltaTime);
        transform.position = smoothPos;

    }

   



}
