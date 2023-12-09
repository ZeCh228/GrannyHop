using System;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] Slider SliderSensivity;
    [SerializeField] Slider VolumeSFX;
    [SerializeField] TMP_InputField SensivityInputField;
    [SerializeField] TMP_InputField InputFieldVolumeSFX;
    [SerializeField] SettingsLoader settingsLoader;
    


    public void UpdateInputFieldSensivityByScrollBar()
    {
        SensivityInputField.text = (Math.Round(SliderSensivity.value, 2).ToString());
    }


    public void UpdateInputFieldVolumeSFX(float Volume)
    {
        InputFieldVolumeSFX.text = (Math.Round(Volume, 2).ToString());
        settingsLoader.VolumeUpdate(Volume);
    }


    public void UpdateScrollBarByInputFieldSensivity(string value)
    {
        float.TryParse(value, out float result);
        Mathf.Clamp(result, 0, settingsLoader.MaxSensivity);

        SliderSensivity.value = result;
    }
    
    public void UpdateScrollBarByInputFieldVolumeSFX(string value)
    {
        float.TryParse(value, out float result);
        Mathf.Clamp(result, 0, settingsLoader.MaxVolume);

        settingsLoader.VolumeUpdate(result);
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
        SensivityInputField.text = (Math.Round(Sensivity, 2).ToString());
    }


    private void UpdateVolumeUI(float Volume)
    {
        VolumeSFX.value = Volume;
        InputFieldVolumeSFX.text = (Math.Round(Volume, 2).ToString());
    }



    public void ResetSettings()
    {
        PlayerPrefs.SetFloat("Sensivity", settingsLoader.DefaultSensivity);
        UpdateSensivityUI(PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity));

        PlayerPrefs.SetFloat("Volume", settingsLoader.DefaultVolume);
        UpdateVolumeUI(PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume));
    }
}
