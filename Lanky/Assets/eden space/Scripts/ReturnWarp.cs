using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnWarp : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (WarpPoint.ignorewarp)
        { return; }
        if (collision.gameObject.tag == "portal")
        {
            transform.position = WarpPoint.Warp;
        }

        if (WarpPoint.ignorewarp)
        { return; }
        if (collision.gameObject.tag == "portaltwo")
        {
            transform.position = WarpPoint.Warp2;
        }*/
    }
    // Start is called before the first frame update
    void Start()
    {
        /*if (WarpPoint.ignorewarp)
            transform.position = WarpPoint.Warp;
        if (WarpPoint.ignorewarp)
            transform.position = WarpPoint.Warp2;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
