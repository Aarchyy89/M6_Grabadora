using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Sound[] soundslist;

    public Slider Slider_volume;
    public Image no_sound;

    public static AudioManager instance;

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
                currentSound.audioSource.mute = currentSound.mute;
            }
               
    }

    public void Sonido_Loop(string soundName) 
    {

        foreach (Sound currentSound in soundslist)
            if (soundName == currentSound.songName)
            {
                currentSound.loop = !currentSound.loop;
                currentSound.audioSource.loop = currentSound.loop;
            }

    }

    public void Sonido_Volumen(string soundName)
    {

        foreach (Sound currentSound in soundslist)
            if (soundName == currentSound.songName)
            {
                //currentSound.loop = !currentSound.loop;
                //currentSound.audioSource.loop = currentSound.loop;
            }

    }

    public void musicaMute()
    {
        if (Slider_volume.value == 0)
        {
            no_sound.enabled = true;
        }
        else
        {
            no_sound.enabled = false;
        }
    }
}
