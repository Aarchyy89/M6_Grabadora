using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config_Manager : MonoBehaviour
{
    private bool loop_sound;
    private bool mute_sound;


   public void Sound_Mute()
    {
          mute_sound = !mute_sound;
    }

    public void Sound_Loop()
    {
        loop_sound = !loop_sound;
    }
}
