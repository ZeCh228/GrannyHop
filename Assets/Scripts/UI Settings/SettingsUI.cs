using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] Slider SliderSensivity;
    [SerializeField] Slider VolumeSFX;
    [SerializeField] TMP_InputField SensivityInputField;
    [SerializeField] TMP_InputField InputFieldVolumeSFX;
    [SerializeField] SettingsLoader settingsLoader;
    


   public void UpdateInputFieldSensivityByScrollBar(float Sensivity) 
    {        
        SensivityInputField.SetTextWithoutNotify(Math.Round(Sensivity, 2).ToString());
    }
    
    
    public void UpdateInputFieldVolumeSFX(float Volume) 
    {
        InputFieldVolumeSFX.SetTextWithoutNotify(Math.Round(Volume, 2).ToString());
    }
    

    public void UpdateScrollBarByInputFieldSensivity(string value) 
    {
        float.TryParse(value, out float result);

        if(result > settingsLoader.MaxSensivity) 
        {
            result = settingsLoader.MaxSensivity;
        }

        SensivityInputField.SetTextWithoutNotify(Math.Round(result, 2).ToString());

        SliderSensivity.value = (float)result;
    }


    public void SaveSettings() 
    {
        PlayerPrefs.SetFloat("Sensivity", SliderSensivity.value);
        PlayerPrefs.SetFloat("Volume", VolumeSFX.value);
        settingsLoader.SensivityUpdate(SliderSensivity.value);

    }


    public void LoadSettingsToUpdateUI()
    {
        float Sensivity = PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity);
        float Volume = PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume);
        UpdateSensivityUI(Sensivity);
        UpdateVolumeUI(Volume);
    }


    private void UpdateSensivityUI(float Sensivity)
    {
        SliderSensivity.value = Sensivity;
        SensivityInputField.SetTextWithoutNotify(Math.Round(Sensivity, 2).ToString());
    }
    
    
    private void UpdateVolumeUI(float Volume)
    {
        VolumeSFX.value = Volume;
        InputFieldVolumeSFX.SetTextWithoutNotify(Math.Round(Volume, 2).ToString());
    }



    public void ResetSettings() 
    {
        PlayerPrefs.SetFloat("Sensivity", settingsLoader.DefaultSensivity);
        UpdateSensivityUI(PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity));
        
        PlayerPrefs.SetFloat("Volume", settingsLoader.DefaultVolume);
        UpdateVolumeUI(PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume));
    }
}
