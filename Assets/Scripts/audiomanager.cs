using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using System;

public class audiomanager : MonoBehaviour
{
    // Start is called before the first frame update
    public audiofile[] sounds;
    public static audiomanager instance;

    
    void Awake()
    {
        if(instance==null)
        {
            instance = this;
        }
        foreach(audiofile s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;
           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
           s.source.loop = s.loop;
        }
    }
  
    // Update is called once per frame
   public void play(string name)
    {
       audiofile s=  Array.Find(sounds, sound => sound.name == name);
       s.source.Play();
    }
    public void stop(string name)
    {
        audiofile s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
    public void setvolume(float t)
    {
       
    }
}
