using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsLoader : MonoBehaviour
{
    public float MaxSensivity;
    public float DefaultSensivity;
    public float DefaultVolume;

    [SerializeField] public float ConvertMixerMinToSliderMin = 0f;
    [SerializeField] public float ConvertMixerMaxToSliderMax = 10f;
    [SerializeField] public float minVolume = -80f;
    [SerializeField] public float maxVolume = 0f;

    [SerializeField] CameraRotation cameraRotation;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] AudioMixer Mixer;
   
    
    

    
    private void Start()
    {
        float Sensivity =  PlayerPrefs.GetFloat("Sensivity", DefaultSensivity);
        //float Volume =  PlayerPrefs.GetFloat("Volume", DefaultVolume);
        float Music =  PlayerPrefs.GetFloat("Music", DefaultVolume);
        float SFX =  PlayerPrefs.GetFloat("SFX", DefaultVolume);
        SensivityUpdate(Sensivity);
       // VolumeUpdate(Volume);
        MusicUpdate(Music);
        SFXUpdate(SFX);
    }


    /*public void VolumeUpdate(float Volume) 
    {   
        
        Mixer.SetFloat("Master", ConvertValue(Volume));

    }*/


    public void MusicUpdate(float Music)
    {

        Mixer.SetFloat("Music", ConvertValue(Music));

    }
    
   
    public void SFXUpdate(float SFX) 
    {        

        Mixer.SetFloat("SFX",ConvertValue(SFX));

    }


    public void SensivityUpdate(float Sensivity)
    {

        cameraRotation.SettingsSet(Sensivity);
        playerMovement.SettingsSet(Sensivity);

    }
    
    float ConvertValue(float originalValue)
    {                
        return (originalValue - ConvertMixerMinToSliderMin) / (ConvertMixerMaxToSliderMax - ConvertMixerMinToSliderMin) * (maxVolume - minVolume) + minVolume;
    }
}
    