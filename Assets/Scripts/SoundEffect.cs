using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    
    public bool isOn;

    public void Start()
    {
        AudioListener.volume = 0f;
    }

    public void OnOffSound()
    {
        if (!isOn)
        {
            AudioListener.volume = 0.3f;
            isOn = true;
        
        }
        else if(isOn){
            AudioListener.volume = 0f;
            isOn = false;
        }
    }

}
