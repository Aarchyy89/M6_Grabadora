using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Paneles")]
    public GameObject Controls_panel;

    private void Start()
    {
        Controls_panel.SetActive(false);    
    }

    public void Panel_Controles()
    {
        Controls_panel.SetActive(true);
    }
}
