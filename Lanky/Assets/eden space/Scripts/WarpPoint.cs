using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public static bool ignorewarp = false;
    public Vector2 Warp = new Vector2(-18.25f, 3.71f);

    public GameObject player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.transform.position = Warp;
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
