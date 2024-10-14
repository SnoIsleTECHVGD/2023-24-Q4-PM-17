using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SceneManagement;
using UnityEngine;

public class AttackingMechanics : MonoBehaviour
{
    public GameObject[] attackMode;
    public List<GameObject> previousGust = GUST.previousGust;

    




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        



     
               
        


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attackMode[0].SetActive(true);
            attackMode[1].SetActive(false);

         
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attackMode[0].SetActive(false);
            attackMode[1].SetActive(true);

            foreach (GameObject obj in previousGust)
            {
                StartCoroutine(DestroyGust(obj));
            }


        }

       




        
        
    }









    IEnumerator DestroyGust(GameObject previousGust)
    {
        yield return new WaitForSeconds(3);
        Destroy(previousGust);
     
    }
}
