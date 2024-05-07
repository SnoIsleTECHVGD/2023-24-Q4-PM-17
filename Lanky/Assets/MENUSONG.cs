using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MENUSONG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.MusicPLayer("MAINMENU");
    }

}
