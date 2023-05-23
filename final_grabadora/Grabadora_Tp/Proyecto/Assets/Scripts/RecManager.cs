using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class RecManager : MonoBehaviour
{
    public bool isRec_Active;
    public bool isPlay_Active;
    public bool isLoop_Active;
    public bool isPause_Active;

    public GameObject content_sound;
    public Item_Sound item_sound;

    public Sound sonido;

    public Button selectedBut_sound;


    [Tooltip("variable para almacenar el tiempo de reproducción entre sonidos")]
    public float counter;

    public List<float> lista_de_tiempos;
    public List<string> lista_nombres_sonidos;


    public IEnumerator currentCorrutine;


    public void LoopSound()
    {
        isLoop_Active = !isLoop_Active;
    }

    public void PauseSound()
    {
        isPause_Active = !isPause_Active;
    }

    public void  Activate_Deactivate_Rec()
    {
        //cambias de true a false
        isRec_Active = !isRec_Active;
        if(isRec_Active)
        {
            counter = 0; 
            

            lista_nombres_sonidos = new List<string>();
            lista_de_tiempos = new List<float>();


            currentCorrutine = Corrutine_REC_Activate();
            StartCoroutine(currentCorrutine);
        }
        else
        {
            StopCoroutine(currentCorrutine);    
        }


    }

    IEnumerator Corrutine_REC_Activate()
    {
        while(isRec_Active) 
        {
            counter += Time.deltaTime;
            yield return null;
        
        }
    }

    public void ActivarPlay()
    {
        currentCorrutine = Coroutine_Play();
        StartCoroutine(currentCorrutine);   
    }

    IEnumerator Coroutine_Play()
    {
        int current_index = 0;
        int maxIndex = lista_de_tiempos.Count;
        isPlay_Active = true;

        while (isPlay_Active)
        {
            if(!isPause_Active)
            {
                counter += Time.deltaTime;
            }
            

            if (current_index < maxIndex)
            {
                if(counter >= lista_de_tiempos[current_index])
                {
                    Debug.Log("Soy el " + lista_nombres_sonidos[current_index]
                        + "en el tiempo" + lista_de_tiempos[current_index]);
                    
                    
                    AudioManager.instance.PlaySong(lista_nombres_sonidos[current_index]);
                    current_index++;
                    counter = 0;
                }
            }
            else
            {
                if(isLoop_Active)
                {
                    counter = 0;
                    current_index = 0;
                }
                else
                {
                    isPlay_Active = false;
                    yield break;
                }

                
            }

            yield return null;
        }
        
    }

    public void AgregarTiempo()
    {
        if(isRec_Active) 
        {
            lista_de_tiempos.Add(counter);
            counter = 0;
        }
    }

    public void AgregarSonido(string songName)
    {
        Sound sonido = AudioManager.instance.DevolverSoundSegunNombre(songName);


        if(sonido != null)
        {
            if (isRec_Active && !sonido.mute)
            {
                lista_nombres_sonidos.Add(songName);
                counter = 0;
                AgregarTiempo();    
            }
        }
        else
        {
            if (isRec_Active)
            {
                lista_nombres_sonidos.Add(songName);
                counter = 0;
                AgregarTiempo();
            }
        }
    }

    public void Spawn_Sound_List()
    {
        Clean_Sound_List();
        foreach (Sound score in AudioManager.instance.templates)
        {
            if (!score.is_Active)
            {
                Item_Sound _item_sound_list;
                _item_sound_list = Instantiate(item_sound, content_sound.transform);
                _item_sound_list.songName = score.songName;
                _item_sound_list.audioClip = score.audioclip;

                //AudioManager.instance.templates.Add(_item_sound_list);   
            }
        }
        
    }

    /// Destrueix els elements de la llista
    private void Clean_Sound_List()
    {
        foreach (Transform child in content_sound.transform)
        {
            Destroy(child.gameObject);
        }
    }

    
}
