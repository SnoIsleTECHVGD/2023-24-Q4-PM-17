using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAndChainAndHook : MonoBehaviour
{
    public GameObject pinwheel;
    private int movespeed = 13;
    [SerializeField] public GameObject player;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            pinwheel.transform.position += new Vector3(movespeed * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            pinwheel.transform.position += new Vector3(player.transform.position.x * Time.deltaTime, player.transform.position.y * Time.deltaTime, player.transform.position.z * Time.deltaTime);
        }
    }
}
