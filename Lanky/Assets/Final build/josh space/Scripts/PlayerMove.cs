
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    public KeyCode  left, right, up, down;
   
    private Rigidbody2D rb2D;
    public float maxSpeed;
    public float buildUp; 


    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            rb2D.velocity = Vector2.left * buildUp;
   
        }
        if (Input.GetKey(right))
        {
            rb2D.velocity = Vector2.right * buildUp;
        }
        if (Input.GetKey(up))
        {
            rb2D.velocity = Vector2.up * buildUp;
        }
        if (Input.GetKey(down))
        {
            rb2D.velocity = Vector2.down * buildUp;
        }

        rb2D.velocity = new Vector2(Mathf.Clamp(rb2D.velocity.x, -maxSpeed, maxSpeed), Mathf.Clamp(rb2D.velocity.y, -maxSpeed, maxSpeed));
    }
}
