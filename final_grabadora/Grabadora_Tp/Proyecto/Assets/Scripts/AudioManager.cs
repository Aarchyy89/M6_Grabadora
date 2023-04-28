using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Sound[] soundslist;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        foreach(Sound currentSound in soundslist)
        {
            currentSound.audioSource = currentSound.gameObject.AddComponent<AudioSource>();
            currentSound.audioSource.clip = currentSound.audioclip;
            currentSound.audioSource.volume = currentSound.volume;
            currentSound.audioSource.playOnAwake = currentSound.playOnAwake;
            currentSound.audioSource.loop = currentSound.loop;
            currentSound.audioSource.mute = currentSound.mute;
        }
    }  
    
    public void PlaySong(string songName)
    {
        foreach (Sound currentSound in soundslist)
        {
            if(currentSound.songName == songName)
            {
                currentSound.audioSource.Play();
                break;
            }
        }
    }

    public void StopSong(string SongName)
    {
        foreach (Sound currentSound in soundslist)
        {
            if (currentSound.songName == SongName)
            {
                currentSound.audioSource.Stop();
                break;
            }
        }
    }


    public Sound DevolverSoundSegunNombre(string soundName)
    {
        foreach (Sound currentSound in soundslist)
        {
            if (soundName == currentSound.songName)
            {
                return currentSound;
                break;
            }
        }

        return null;
    }

    public void Sonido_Mute(string soundName)
    {
        foreach (Sound currentSound in soundslist)
            if(soundName == currentSound.songName)
            {
                currentSound.mute = !currentSound.mute;
            }
               
    }

    public void Sonido_Loop(string soundName) 
    {

        foreach (Sound currentSound in soundslist)
            if (soundName == currentSound.songName)
            {
                currentSound.loop = !currentSound.loop;
            }

    }
}
