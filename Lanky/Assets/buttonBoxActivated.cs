using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonBoxActivated : MonoBehaviour
{
   
    public Transform wall;
    private Vector2 endPositon;
    private bool doorCanMove;
    public GameObject camSwitch;
    public Rigidbody2D ButtonRB;
    public GameObject button;
    void Start()
    {
        endPositon = new Vector2(wall.position.x, wall.position.y + 0.4f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(wall.position.y - endPositon.y) > 0.01f && doorCanMove)
        {
            Debug.Log("platform is moving.");
            wall.position = Vector2.MoveTowards(wall.position, endPositon, 0.3f * Time.deltaTime);
        }
        if (wall.position.y == -1.624)
        {
            doorCanMove = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Button"))
        {
            button.SetActive(false);
            doorCanMove = true;
        }
    }

}
