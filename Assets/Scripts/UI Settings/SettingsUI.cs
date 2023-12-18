using System;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] Slider SliderSensivity;
    [SerializeField] Slider VolumeMusic;
    [SerializeField] Slider SFXVolume;
    [SerializeField] TMP_InputField SensivityInputField;
    [SerializeField] TMP_InputField InputFieldMusic;
    [SerializeField] TMP_InputField InputFieldSFX;
    [SerializeField] SettingsLoader SettingsLoader;
    [SerializeField] Toggle ToggleInvert;
    //[SerializeField] Slider MasterVolume;
    //[SerializeField] TMP_InputField InputFieldMasterVolume;


    public void Invert(bool InvertValue) 
    {
        PlayerPrefs.SetInt("Invert", InvertValue == true ? 1 : 0); // тернарный oператор ?
        SettingsLoader.UpdateInvert(InvertValue);
    }



    public void UpdateInputFieldSensivityByScrollBar()
    {
        SensivityInputField.text = (Math.Round(SliderSensivity.value, 2).ToString());
    }



    /* public void UpdateInputFieldMasterVolume(float Volume)
     {
        // InputFieldMasterVolume.text = (Mathf.RoundToInt(Volume).ToString());
       //  settingsLoader.VolumeUpdate(Volume);
     }*/



    public void UpdateInputFieldVolumeMusic(float Music)
    {
        InputFieldMusic.text = (Mathf.RoundToInt(Music).ToString());
        SettingsLoader.MusicUpdate(Music);
    }



    public void UpdateInputFieldVolumeSFX(float SFX)
    {
        InputFieldSFX.text = (Mathf.RoundToInt(SFX).ToString());
        SettingsLoader.SFXUpdate(SFX);
    }



    public void UpdateScrollBarByInputFieldSensivity(string value)
    {
        float.TryParse(value, out float result);
        SliderSensivity.value = Mathf.Clamp(result, 0, SettingsLoader.MaxSensivity);
    }



    /* public void UpdateScrollBarByInputFieldMasterVolume(string value)
     {
         float.TryParse(value, out float result);
         Mathf.Clamp(result, 0, settingsLoader.ConvertMixerMaxToSliderMax);

         settingsLoader.VolumeUpdate(result);
     }*/



    public void UpdateScrollBarByInputFieldMusic(string value)
    {
        float.TryParse(value, out float result);
        
        result = Mathf.Clamp(result, 0, SettingsLoader.ConvertMixerMaxToSliderMax);
        SettingsLoader.MusicUpdate(result);
        VolumeMusic.value = result;
    }



    public void UpdateScrollBarByInputFieldSFX(string value)
    {
        float.TryParse(value, out float result);
        Mathf.Clamp(result, 0, SettingsLoader.ConvertMixerMaxToSliderMax);

        SettingsLoader.SFXUpdate(result);
        SFXVolume.value = result;
    }



    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("Sensivity", SliderSensivity.value);
        //PlayerPrefs.SetFloat("Volume", MasterVolume.value);
        PlayerPrefs.SetFloat("Music", VolumeMusic.value);
        PlayerPrefs.SetFloat("SFX", SFXVolume.value);
        SettingsLoader.SensivityUpdate(SliderSensivity.value);
    }

    

    public void LoadSettingsToUpdateUI()
    {
        float Sensivity = PlayerPrefs.GetFloat("Sensivity", SettingsLoader.DefaultSensivity);
        // float Volume = PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume);
        float Music = PlayerPrefs.GetFloat("Music", SettingsLoader.DefaultVolume);
        float SFX = PlayerPrefs.GetFloat("SFX", SettingsLoader.DefaultVolume);
        UpdateSensivityUI(Sensivity);
        //UpdateMasterVolumeInUI(Volume);
        UpdateMusicInUI(Music);
        UpdateSFXInUI(SFX);
        InvertUpdate();
    }


    private void InvertUpdate() 
    {

     ToggleInvert.isOn = PlayerPrefs.GetInt("Invert") == 0 ? false : true;
     
    }



    private void UpdateSensivityUI(float Sensivity)
    {
        SliderSensivity.value = Sensivity;
        SensivityInputField.text = (Math.Round(Sensivity, 2).ToString());
    }



    /* private void UpdateMasterVolumeInUI(float Volume)
     {
         MasterVolume.value = Volume;
         InputFieldMasterVolume.text = (Mathf.RoundToInt(Volume).ToString());       
     } */

    

    private void UpdateMusicInUI(float Music)
    {
        VolumeMusic.value = Music;
        InputFieldMusic.text = (Mathf.RoundToInt(Music).ToString());
    }


    private void UpdateSFXInUI(float SFX)
    {
        SFXVolume.value = SFX;
        InputFieldSFX.text = (Mathf.RoundToInt(SFX).ToString());
    }



    public void ResetSettings()
    {
        PlayerPrefs.SetFloat("Sensivity", SettingsLoader.DefaultSensivity);
        UpdateSensivityUI(PlayerPrefs.GetFloat("Sensivity", SettingsLoader.DefaultSensivity));

        /* PlayerPrefs.SetFloat("Volume", settingsLoader.DefaultVolume);
         UpdateMasterVolumeInUI(PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume));*/

        PlayerPrefs.SetFloat("Music", SettingsLoader.DefaultVolume);
        UpdateMusicInUI(PlayerPrefs.GetFloat("Music", SettingsLoader.DefaultVolume));

        PlayerPrefs.SetFloat("SFX", SettingsLoader.DefaultVolume);
        UpdateSFXInUI(PlayerPrefs.GetFloat("SFX", SettingsLoader.DefaultVolume));
    }
}
