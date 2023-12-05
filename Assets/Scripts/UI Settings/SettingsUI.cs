using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] Slider SliderSensivity;
    [SerializeField] TMP_InputField SensivityInputField;
    [SerializeField] SettingsLoader settingsLoader;

   public void UpdateInputFieeldSensivityByScrollBar(float Sensivity) 
    {        
        SensivityInputField.SetTextWithoutNotify(Math.Round(Sensivity, 2).ToString());
    }
    

    public void UpdateScrollBarByInputFieldSensivity(string value) 
    {
        decimal.TryParse(value, out decimal result);

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
        settingsLoader.SensivityUpdate(SliderSensivity.value);
    }

    public void LoadSettingsToUpdateUI()
    {
        float Sensivity = PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity);
        UpdateSensivityUI(Sensivity);
    }

    private void UpdateSensivityUI(float Sensivity)
    {
        SliderSensivity.value = Sensivity;
        SensivityInputField.SetTextWithoutNotify(Math.Round(Sensivity, 2).ToString());
    }


    public void DefaultSensa() 
    {
        PlayerPrefs.SetFloat("Sensivity", settingsLoader.DefaultSensivity);
        UpdateSensivityUI(PlayerPrefs.GetFloat("Sensivity", settingsLoader.DefaultSensivity));
    }
}
