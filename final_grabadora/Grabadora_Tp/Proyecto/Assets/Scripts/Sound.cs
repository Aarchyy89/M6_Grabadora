using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SerializeField]
public class Sound : MonoBehaviour
{
    public string songName;
    public AudioClip audioclip;


    [Range(0f, 1f)]
    public float volume;

    public bool playOnAwake;
    public bool loop;
    public bool mute;
    public AudioSource audioSource;





}
