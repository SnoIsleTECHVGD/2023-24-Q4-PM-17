using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Title()
    {
        SceneManager.LoadScene("Main Title");
    }
}