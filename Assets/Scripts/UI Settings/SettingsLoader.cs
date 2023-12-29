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

    [SerializeField] CameraRotation CameraRotation;
    [SerializeField] PlayerMovement PlayerMovement;
    [SerializeField] AudioMixer Mixer;
    [SerializeField] bool NeedToUpdatePlayer = true;

    private void Start()
    {
        float Sensivity = PlayerPrefs.GetFloat("Sensivity", DefaultSensivity);
        float Music = PlayerPrefs.GetFloat("Music", DefaultVolume);
        float SFX = PlayerPrefs.GetFloat("SFX", DefaultVolume);
        SensivityUpdate(Sensivity);
        MusicUpdate(Music);
        SFXUpdate(SFX);
        UpdateInvert(PlayerPrefs.GetInt("Invert", 1) == -1 ? false : true);
    }

  
    public void UpdateInvert(bool Invert)
    {
        if (NeedToUpdatePlayer == false)
            return;
        if (Invert == true)
        {
            PlayerMovement.Invertion = -1;
            CameraRotation.Invertion = -1;
        }
        else
        {
            PlayerMovement.Invertion = 1;
            CameraRotation.Invertion = 1;
        }

    }


    public void MusicUpdate(float Music)
    {

        Mixer.SetFloat("Music", ConvertValue(Music));

    }


    public void SFXUpdate(float SFX)
    {

        Mixer.SetFloat("SFX", ConvertValue(SFX));

    }


    public void SensivityUpdate(float Sensivity)
    {
        if (NeedToUpdatePlayer == false)
            return;

        CameraRotation.SettingsSet(Sensivity);
        PlayerMovement.SettingsSet(Sensivity);

    }

    float ConvertValue(float originalValue)
    {
        return (originalValue - ConvertMixerMinToSliderMin) / (ConvertMixerMaxToSliderMax - ConvertMixerMinToSliderMin) * (maxVolume - minVolume) + minVolume;
    }
}
