using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject Controls_panel;

    public Sound sonido;
    public Sound backup;
    public TextMeshProUGUI Selectable_but;
    public int currentindex = 0;

    [Header("---Texto a Actualizar---")]
    public TextMeshProUGUI Texto_a_Actualizar;

    public static UIManager instance;

    public string _sounds;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentindex = 0;
        Controls_panel.SetActive(false);    
    }

    public void Actualizar_Slider()
    {
        AudioManager.instance.Slider_volume.value = AudioManager.instance.soundslist[currentindex].audioSource.volume;
    }


    public void Panel_Controles()
    {
        Controls_panel.SetActive(true);
        Selectable_but.text = "1";
        sonido = AudioManager.instance.soundslist[currentindex];
        backup = sonido;

        AudioManager.instance.Sonido_Volumen();
    }

    public void Seletable_But_Access(string songName)
    {
        Sound sonido = AudioManager.instance.DevolverSoundSegunNombre(songName);

    }

    public void Selectable_But_Plus()
    {
        if (currentindex + 1 < AudioManager.instance.soundslist.Length)
        {
            currentindex++;
        }
        else
        {
            currentindex = 0;
        }

        sonido = AudioManager.instance.soundslist[currentindex];
        backup = sonido;
        Selectable_but.text = currentindex + 1 + "";
        Actualizar_Texto_Actualizable();
        Actualizar_Slider();

    }

    public void Selectable_But_Minus()
    {
        if (currentindex - 1 > 0)
        {
            currentindex--;
        }
        else
        {
            currentindex = AudioManager.instance.soundslist.Length  -1;
        }

        sonido = AudioManager.instance.soundslist[currentindex];
        Selectable_but.text = currentindex + 1 + "";
        Actualizar_Texto_Actualizable();
        Actualizar_Slider();
    }

    public void Actualizar_Texto_Actualizable()
    {
        Texto_a_Actualizar.text = "";
        Texto_a_Actualizar.text = sonido.songName + " ";
    }


    public void _Api(string template)
    {
        _sounds = template;
    }

    public void iGUALAR_AUDIO()
    {
        foreach (var sound in AudioManager.instance.templates)
        {
            if(sound.songName == _sounds)
            {
                sonido.songName = sound.songName;
                sonido.audioclip = sound.audioclip;
                sonido.audioSource.clip = sonido.audioclip;
                sound.songName = backup.songName;
                sound.audioclip = backup.audioclip;

            }
        }
    }
}
