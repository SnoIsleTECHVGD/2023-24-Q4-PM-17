using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashWhen : MonoBehaviour
{
    [SerializeField] private Material flashMaterial;

    [SerializeField] private float duration;

    private SpriteRenderer spriteRenderer;
    private Material originialMaterial;
    private Coroutine flashRoutine;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        originialMaterial = spriteRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private IEnumerator Flashing()
    {
        spriteRenderer.material = flashMaterial;

        yield return new WaitForSeconds(duration);

        spriteRenderer.material = originialMaterial;

        flashRoutine = null;
    }


    public void Flash()
    {
        if(flashRoutine != null)
        {
            StopCoroutine(flashRoutine);
        }


        flashRoutine = StartCoroutine(Flashing());
    }
}
