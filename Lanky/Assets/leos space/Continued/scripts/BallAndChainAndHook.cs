using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallAndChainAndHook : MonoBehaviour
{
    public GameObject pinwheel;
    private int movespeed = 10;
    [SerializeField] public GameObject player;
    public float maxDistance;
    public Vector2 target;
    private bool extending;
    private bool retracting;

    public LineRenderer theLine;
    public PlayerControllerAndAnimator FREEZE;

    
    private Vector2 wheelStartPoint;
    private float currentDistance;

    public Animator DISABLE;

    public LineRenderer pinString;
    public GameObject attackArea;
    public static GameObject hookedEnemy;

    private float stringThreshold = 0.1f;
    private bool hookComplete;

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
        if(AttackArea.isHooked && PlayerControllerAndAnimator.isGrounded)
        {
            Hook();
            player.GetComponent<health>().Damage(0);

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
        DISABLE.SetBool("isRunning",false);
        FREEZE.GetComponent<PlayerControllerAndAnimator>().enabled = false;
        float exceleration = movespeed * Time.deltaTime;



        pinwheel.transform.position = Vector2.Lerp(pinwheel.transform.position, target, exceleration);
        currentDistance = Vector2.Distance(player.transform.position,pinwheel.transform.position);
        attackArea.SetActive(true);
        if (currentDistance >= maxDistance || Vector2.Distance(pinwheel.transform.position, target) < stringThreshold)
        {

           
            extending = false;
            retracting = true;
        }

        DrawLine();
    }


    void Retraction()
    {
        float exceleration = movespeed * Time.deltaTime;

        pinwheel.transform.position = Vector2.Lerp(pinwheel.transform.position,player.transform.position,exceleration);
        
        if(Vector2.Distance(pinwheel.transform.position, player.transform.position) < stringThreshold)
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
        DISABLE.SetBool("isRunning", true);
        FREEZE.GetComponent<PlayerControllerAndAnimator>().enabled = true;
        AttackArea.isHooked = false;
        DrawLine();

    }

   

    void DrawLine()
    {
        if (pinString != null)
        {
            pinString.SetPosition(0, player.transform.position);
            pinString.SetPosition(1, pinwheel.transform.position);
        }
    }

    void Hook()
    {
        float hookSpeed = movespeed * Time.deltaTime;
        
        
        if(AttackArea.ballAndChainScript != null)
        {
           AttackArea.ballAndChainScript.transform.position = Vector2.Lerp(AttackArea.ballAndChainScript.transform.position, player.transform.position, hookSpeed);
           pinwheel.transform.position = Vector2.Lerp(pinwheel.transform.position, player.transform.position, hookSpeed);
          
           DrawLine();

            Collider2D[] hits = Physics2D.OverlapCircleAll(player.transform.position, stringThreshold);
            foreach (var hit in hits)
            {
                if (hit.gameObject == AttackArea.ballAndChainScript)
                {
                    retracting = false;
                    hookComplete = true;
                    WheelHasBeenReset();
                }
            }
        }
    }
}


