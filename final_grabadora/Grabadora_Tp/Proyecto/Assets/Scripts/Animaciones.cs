using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animaciones : MonoBehaviour
{
    public Button ButooonLoop;





    public void CambiarAnimacion()
    {
        ButooonLoop.GetComponent<Animator>().SetTrigger("IsPressed");

    }

  

}
