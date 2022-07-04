using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class soundManager : MonoBehaviour
{
    public Sound[] sounds;

    void Awake ()
    {
        foreach (Sound s in sounds)
        {
            s.Audio = gameObject.AddComponent<AudioSource>();
            s.Audio.clip = s.clip;
            s.Audio.volume = s.volume;
            s.Audio.pitch = s.pitch;
        }
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.Audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
