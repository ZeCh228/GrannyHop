using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsLoader : MonoBehaviour
{
    public decimal MaxSensivity;
    public float DefaultSensivity;
    [SerializeField] CameraRotation cameraRotation;
    [SerializeField] PlayerMovement playerMovement;


    
    private void Awake()
    {

        float Sensivity =  PlayerPrefs.GetFloat("Sensivity", DefaultSensivity);
        SensivityUpdate(Sensivity);
    }


    public void SensivityUpdate(float Sensivity)
    {
        cameraRotation.SettingsSet(Sensivity);
        playerMovement.SettingsSet(Sensivity);
    }
}
    