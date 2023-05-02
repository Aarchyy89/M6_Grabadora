using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject Controls_panel;

    public TextMeshProUGUI Selectable_but;
    public int currentindex = 0;

    private void Start()
    {
        Controls_panel.SetActive(false);    
    }

    public void Panel_Controles()
    {
        Controls_panel.SetActive(true);
        Selectable_but.text = "1";
    }

    public void Seletable_But_Plus(string songName)
    {
        Sound sonido = AudioManager.instance.DevolverSoundSegunNombre(songName);
        sonido = AudioManager.instance.soundslist[currentindex + 1];
        Selectable_but.text = currentindex + 1  + "";
        Debug.Log("Hola");

    }

    public void Selectable_But_Minus()
    {

    }
}
