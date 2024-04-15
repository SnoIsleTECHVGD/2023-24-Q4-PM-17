using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpPoint : MonoBehaviour
{
    public static Vector2 Warp = new Vector2(39.22f, -8.72f);

    public GameObject player;
    public string RoomName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Warp = player.transform.position;
        SceneManager.LoadScene(RoomName);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
