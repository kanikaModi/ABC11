using UnityEngine.Audio;
using UnityEngine;
using System;

public class audiomanager : MonoBehaviour {

    // Use this for initialization
    public sounds[] sound;
	void Awake () {
		foreach(sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.pitch = s.pitch;
            s.source.volume = s.volume;
            s.source.loop = s.loop;

        }
	}

    public void Play(string name)
    {
        sounds s = Array.Find(sound, sounds => sounds.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found");
            return;
        }
        s.source.Play();
    }
}
