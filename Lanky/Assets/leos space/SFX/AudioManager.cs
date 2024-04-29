using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] Music, Sfx;
    public AudioSource musicSource,sfxSource;
    public static AudioManager Instance;


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
       //plays music once the game starts, no music currently.
    }


    public void MusicPLayer ( string name)
    {
        Sound s = Array.Find(Music, x => x.name == name);

        if( s == null )
        {
            Debug.Log("no sound..");
        }

        else
        {
            musicSource.clip = s.soundClip;
            musicSource.Play();
        }
    }


    public void PlaySFX(string name)
    {
        Sound s = Array.Find(Sfx, x => x.name == name);

        if (s == null)
        {
            Debug.Log("no sound..");
        }

        else 
        {
            sfxSource.PlayOneShot(s.soundClip);
        }
    }
}
