using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item_Sound : MonoBehaviour
{
    public string songName;
    public AudioClip audioClip;

    void Start()
    {
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = songName;
        transform.GetChild(1).GetComponent<Button>().onClick.AddListener(PlaySound);
        transform.GetChild(2).GetComponent<Button>().onClick.AddListener(Swap_);
        
        //transform.GetChild(2).GetComponent<Button>().onClick.AddListener(Paus);
    }

    private void PlaySound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }

    private void Swap_()
    {
        UIManager.instance._Api(songName);
        UIManager.instance.iGUALAR_AUDIO();
    }

}
