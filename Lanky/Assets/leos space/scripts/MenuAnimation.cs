using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuAnimation : MonoBehaviour
{
    public Transform menu;
    public CanvasGroup bg;


    private void OnEnable()
    {
        bg.alpha = 0;
        menu.localPosition = new Vector2(0, -Screen.height);
    }


    
}
