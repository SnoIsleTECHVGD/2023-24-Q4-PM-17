using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            transform.gameObject.SetActive(true);
        }

    }
}
