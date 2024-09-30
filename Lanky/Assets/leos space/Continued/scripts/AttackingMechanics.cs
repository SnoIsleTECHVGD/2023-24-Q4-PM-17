using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingMechanics : MonoBehaviour
{
    public GameObject[] attackMode;
    public GameObject[] previousGust;

  


   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {





        //FindObjectOfType<>
        
       if (previousGust == null)
        {
            //previousGust = GetComponent<GUST>();
            {
                foreach (GameObject obj in previousGust)
                {
                    Destroy(obj);
                }
            }



        }

        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackMode[0].SetActive(true);
            attackMode[1].SetActive(false);

         
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackMode[0].SetActive(false);
            attackMode[1].SetActive(true);


        }

       




        
        
    }









    IEnumerator DestroyGust(GameObject previousGust)
    {
        yield return new WaitForSeconds(3);
        Destroy(previousGust);
     
    }
}
