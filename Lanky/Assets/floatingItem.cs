using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class floatingItem : MonoBehaviour
{
    private Vector3 startPos;

    public float amplitude = 0.4f;
    private float speed;

    public float frequency =0.3f;
  
    private void Start()
    {
        startPos = transform.position;
    }




    void Update()
    {
       float Y = startPos.y + Mathf.Sin(Time.time * frequency) * amplitude;
       


        transform.position = new Vector3(startPos.x, Y, startPos.z);
    }
}
