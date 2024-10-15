using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBox : MonoBehaviour
{
    public Transform stationArea;

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null && collision.CompareTag("Crate"))
        {

            Debug.Log("moved");
            collision.gameObject.transform.position = Vector3.MoveTowards(collision.gameObject.transform.position, stationArea.position, 4 * Time.deltaTime);
        }
    }
}
