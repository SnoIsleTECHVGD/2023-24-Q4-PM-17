using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    public MonoBehaviour[] Toggle;

  
  


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Toggle[0].enabled = true;
            Toggle[0].gameObject.SetActive(true);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);
          

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = true;
            Toggle[1].gameObject.SetActive(true);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);

        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = true;
            Toggle[2].gameObject.SetActive(true);
            Toggle[3].enabled = false;
            Toggle[3].gameObject.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Toggle[0].enabled = false;
            Toggle[0].gameObject.SetActive(false);
            Toggle[1].enabled = false;
            Toggle[1].gameObject.SetActive(false);
            Toggle[2].enabled = false;
            Toggle[2].gameObject.SetActive(false);
            Toggle[3].enabled = true;
            Toggle[3].gameObject.SetActive(true);
        }

    }
}
