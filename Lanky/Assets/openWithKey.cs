using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class openWithKey : MonoBehaviour
{

    public static bool KeyObtained;
    private bool doorCanMove;
    public float speed;
    private Vector2 endPositon;
    void Start()
    {


        endPositon = new Vector2(transform.position.x, transform.position.y + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.y - endPositon.y) > 0.01f && doorCanMove)
        {
            transform.position = Vector2.MoveTowards(transform.position, endPositon, speed * Time.deltaTime);
        }
        if(transform.position.y == -1.624)
        {
            doorCanMove = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (KeyObtained && collision.gameObject.CompareTag("player"))
        {
            doorCanMove = true;
        }
    }
}
