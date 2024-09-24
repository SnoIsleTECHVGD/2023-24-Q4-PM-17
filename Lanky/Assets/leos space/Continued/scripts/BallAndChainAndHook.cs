using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallAndChainAndHook : MonoBehaviour
{
    public GameObject pinwheel;
    private int movespeed = 13;
    [SerializeField] public GameObject player;
    public float maxDistance;
    public Vector2 target;
    private bool extending;
    private bool retracting;
    public PlayerControllerAndAnimator FREEZE;

    private Vector2 wheelStartPoint;
    private float currentDistance;
    public Animator DISABLE;

    public LineRenderer pinString;
    public GameObject attackArea;

    void Start()
    {
        wheelStartPoint = player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        controller();
        
        
        if(extending && PlayerControllerAndAnimator.isGrounded)
        {
            Extension();
            
        }
        else if (retracting)
        {
            Retraction();
        }



       
       
        
        //if (Input.GetKey(KeyCode.E))
        {
           // pinwheel.transform.position += new Vector3(movespeed * Time.deltaTime, 0, 0);
        }

       // else if(Input.GetKeyUp(KeyCode.E))
        {
           // pinwheel.transform.position += new Vector3(player.transform.position.x * Time.deltaTime, player.transform.position.y * Time.deltaTime, player.transform.position.z * Time.deltaTime);
        }
    }


    void controller()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
         
            extending = true;
            retracting = false;
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        }


        if(Input.GetKeyUp(KeyCode.E))
        {
            extending = false;
            retracting = true;
        }
    }


    void Extension()
    {
        FREEZE.GetComponent<PlayerControllerAndAnimator>().enabled = false;
        DISABLE.SetBool("isRunning",false);
        float exceleration = movespeed * Time.deltaTime;



        pinwheel.transform.position = Vector2.MoveTowards(pinwheel.transform.position, target, exceleration);
        currentDistance = Vector2.Distance(player.transform.position,pinwheel.transform.position);

        if (currentDistance >= maxDistance || pinwheel.transform.position == (Vector3)target)
        {

            attackArea.SetActive(true);
            extending = false;
            retracting = true;
        }

        DrawLine();
    }


    void Retraction()
    {
        float exceleration = movespeed * Time.deltaTime;

        pinwheel.transform.position = Vector2.MoveTowards(pinwheel.transform.position,player.transform.position,exceleration);
        
        if( pinwheel.transform.position == player.transform.position)
        {
            retracting = false;
            WheelHasBeenReset();
            
        }
        DrawLine();
    }


    void WheelHasBeenReset()
    {
        currentDistance = 0f;
        attackArea.SetActive(false);
        pinwheel.transform.position = player.transform.position;
        FREEZE.GetComponent<PlayerControllerAndAnimator>().enabled = true;
        DISABLE.SetBool("isRunning", true);

    }


    void DrawLine()
    {
        if (pinString != null)
        {
            pinString.SetPosition(0, player.transform.position);
            pinString.SetPosition(1, pinwheel.transform.position);
        }
    }
}


