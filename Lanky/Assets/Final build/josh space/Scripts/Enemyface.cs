using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyface : MonoBehaviour
{
    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    { Vector3 playerPosition = Input.mousePosition;
        playerPosition = Camera.main.ScreenToWorldPoint(playerPosition);
        Vector2 direction = new Vector2(
            playerPosition.x - transform.position.x,
            playerPosition.y - transform.position.y);
        transform.right= direction;
        
    }
}
