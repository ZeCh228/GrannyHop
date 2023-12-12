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
    [SerializeField] SettingsLoader settingsLoader;

    //[SerializeField] Slider MasterVolume;
    //[SerializeField] TMP_InputField InputFieldMasterVolume;

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
        settingsLoader.MusicUpdate(Music);
    }



    public void UpdateInputFieldVolumeSFX(float SFX)
    {
        InputFieldSFX.text = (Mathf.RoundToInt(SFX).ToString());
        settingsLoader.SFXUpdate(SFX);
    }



    public void UpdateScrollBarByInputFieldSensivity(string value)
    {
        float.TryParse(value, out float result);
        SliderSensivity.value = Mathf.Clamp(result, 0, settingsLoader.MaxSensivity);
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
        
        result = Mathf.Clamp(result, 0, settingsLoader.ConvertMixerMaxToSliderMax);
        settingsLoader.MusicUpdate(result);
        VolumeMusic.value = result;
    }



    public void UpdateScrollBarByInputFieldSFX(string value)
    {
        float.TryParse(value, out float result);
        Mathf.Clamp(result, 0, settingsLoader.ConvertMixerMaxToSliderMax);

        settingsLoader.SFXUpdate(result);
        SFXVolume.value = result;
    }



    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("Sensivity", SliderSensivity.value);
        //PlayerPrefs.SetFloat("Volume", MasterVolume.value);
        PlayerPrefs.SetFloat("Music", VolumeMusic.value);
        PlayerPrefs.SetFloat("SFX", SFXVolume.value);
        settingsLoader.SensivityUpdate(SliderSensivity.value);
    }



    public void LoadSettingsToUpdateUI()
    {
        float Sensivity = PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity);
        // float Volume = PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume);
        float Music = PlayerPrefs.GetFloat("Music", settingsLoader.DefaultVolume);
        float SFX = PlayerPrefs.GetFloat("SFX", settingsLoader.DefaultVolume);
        UpdateSensivityUI(Sensivity);
        //UpdateMasterVolumeInUI(Volume);
        UpdateMusicInUI(Music);
        UpdateSFXInUI(SFX);
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
        PlayerPrefs.SetFloat("Sensivity", settingsLoader.DefaultSensivity);
        UpdateSensivityUI(PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity));

        /* PlayerPrefs.SetFloat("Volume", settingsLoader.DefaultVolume);
         UpdateMasterVolumeInUI(PlayerPrefs.GetFloat("Volume", settingsLoader.DefaultVolume));*/

        PlayerPrefs.SetFloat("Music", settingsLoader.DefaultVolume);
        UpdateMusicInUI(PlayerPrefs.GetFloat("Music", settingsLoader.DefaultVolume));

        PlayerPrefs.SetFloat("SFX", settingsLoader.DefaultVolume);
        UpdateSFXInUI(PlayerPrefs.GetFloat("SFX", settingsLoader.DefaultVolume));
    }
}
