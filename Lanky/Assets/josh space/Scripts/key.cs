using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    public GameObject door;
    public GameObject breakpart;
    public GameObject Key;
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D trigger2D)
    {
        if (trigger2D.gameObject.tag == "player")
        {
            Debug.Log("you have picked up the key" );
           
            Destroy(breakpart);

            SceneManager.LoadScene("MainWin");
            Destroy(Key);
        }

       
    }
}
