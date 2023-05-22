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
        //gameObject.GetComponent<Button>().onClick.AddListener(Refresh_Selected_Sound);
        //transform.GetChild(2).GetComponent<Button>().onClick.AddListener(Paus);
    }

    private void PlaySound()
    {
        gameObject.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }

}
