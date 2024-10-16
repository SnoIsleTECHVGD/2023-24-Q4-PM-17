using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public static bool ignorewarp = false;
    public Vector3 Warp = new Vector3(-18.25f, 3.71f);

    public GameObject player;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject arrowUp;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = Warp;

        if(CompareTag("portal1"))
        {
          cam1.SetActive(false);
            cam2.SetActive(true);
            cam2.tag = ("MainCamera");
            cam1.tag = ("Untagged");
        }
        if (CompareTag("portal2"))
        {
            arrowUp.SetActive(true);
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam2.tag = ("Untagged");
            cam1.tag = ("MainCamera");
            cam3.tag = ("Untagged");
        }

        //SceneManager.LoadScene(RoomName);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
