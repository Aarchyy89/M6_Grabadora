using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animaciones : MonoBehaviour
{
    public Button ButooonLoop;
    public Button ButooonPlay;
    public Button ButoonPause;
    public Button ButooonRec;

    public Button ButooonMute;
    public Button ButooonMute2;
    public Button ButooonMute3;
    public Button ButooonMute4;
    public Button ButooonMute5;
    public Button ButooonMute6;
    public Button ButooonMute7;
    public Button ButooonMute8;
    public Button ButooonMute9;

    public Button ButooonLop;
    public Button ButooonLop2;
    public Button ButooonLop3;
    public Button ButooonLop4;
    public Button ButooonLop5;
    public Button ButooonLop6;
    public Button ButooonLop7;
    public Button ButooonLop8;
    public Button ButooonLop9;
 
    public bool IsPressed;

       

    public void CambiarAnimacionLoop()
    {
        IsPressed = !IsPressed;
       
        if (IsPressed)
        {
            ButooonLoop.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLoop.GetComponent<Animator>().SetBool("IsPressed", true);
        } else
        {
            ButooonLoop.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionPlay()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonPlay.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonPlay.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonPlay.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionPause()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButoonPause.GetComponent<Animator>().SetTrigger("Pressed");
            ButoonPause.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButoonPause.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionRec()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonRec.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonRec.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonRec.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
  
    public void CambiarAnimacionLop2()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop2.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop2.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop2.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop3()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop3.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop3.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop3.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop4()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop4.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop4.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop4.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop5()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop5.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop5.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop5.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop6()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop6.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop6.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop6.GetComponent<Animator>().SetBool("IsPressed", false);
        }

    }
    public void CambiarAnimacionLop7()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop7.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop7.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop7.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionLop8()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop8.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop8.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop8.GetComponent<Animator>().SetBool("IsPressed", false);
        }
       
    }
    public void CambiarAnimacionLop9()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonLop9.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonLop9.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonLop9.GetComponent<Animator>().SetBool("IsPressed", false);
        }

    }
    public void CambiarAnimacionMute()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute2()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute2.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute2.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute2.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute3()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute3.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute3.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute3.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute4()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute4.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute4.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute4.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute5()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute5.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute5.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute5.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute6()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute6.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute6.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute6.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute7()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute7.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute7.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute7.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute8()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute8.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute8.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute8.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
    public void CambiarAnimacionMute9()
    {
        IsPressed = !IsPressed;

        if (IsPressed)
        {
            ButooonMute9.GetComponent<Animator>().SetTrigger("Pressed");
            ButooonMute9.GetComponent<Animator>().SetBool("IsPressed", true);
        }
        else
        {
            ButooonMute9.GetComponent<Animator>().SetBool("IsPressed", false);
        }
    }
}
