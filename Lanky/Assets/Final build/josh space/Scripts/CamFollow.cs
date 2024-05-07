 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 2f;
    public Vector3 offset;
   
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
