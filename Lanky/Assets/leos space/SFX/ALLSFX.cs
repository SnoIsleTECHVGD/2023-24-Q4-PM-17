using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALLSFX : MonoBehaviour
{
    public void ButtonClick()
    {
        AudioManager.Instance.PlaySFX("Button_click_Enter");
    }
    public void BackButtonClick()
    {
        AudioManager.Instance.PlaySFX("Back_Button_click");
    }
    public void PageOpener()
    {
        AudioManager.Instance.PlaySFX("Page_flip");
    }
    public void PageSlide()
    {
        AudioManager.Instance.PlaySFX("Page_Slide");
    }

}
