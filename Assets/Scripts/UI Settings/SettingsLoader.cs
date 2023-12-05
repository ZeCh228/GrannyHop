using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsLoader : MonoBehaviour
{
    public float MaxSensivity;
    public float DefaultSensivity;
    public float DefaultVolume;
    [SerializeField] CameraRotation cameraRotation;
    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] AudioMixer MixerSFX;


    
    private void Awake()
    {
        float Sensivity =  PlayerPrefs.GetFloat("Sensivity", DefaultSensivity);
        float Volume =  PlayerPrefs.GetFloat("Volume", DefaultVolume);
        SensivityUpdate(Sensivity);
    }


    public void VolumeUpdate(float Volume) 
    {
        //MixerSFX.SetFloat(Volume);
    }


    public void SensivityUpdate(float Sensivity)
    {
        cameraRotation.SettingsSet(Sensivity);
        playerMovement.SettingsSet(Sensivity);
    }
}
    