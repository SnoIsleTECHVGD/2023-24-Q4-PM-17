using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Paralax : MonoBehaviour
{
    private float lenth, startpos;
    public GameObject cam;
    public float paralaxEffect;
    void Start()
    {
        startpos = transform.position.x;
        lenth = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - paralaxEffect));
        float distance = (cam.transform.position.x * paralaxEffect);

        transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

        if (temp > startpos + lenth) startpos += lenth;
        else if( temp < startpos - lenth) startpos -= lenth;
    }
}
