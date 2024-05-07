using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freshWobble : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 60f;
   public float wobbleAng = 65f;
    public float startWobble = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotateSpeed, wobbleAng ) - startWobble);
    }
}
