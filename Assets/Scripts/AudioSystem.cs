using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] AudioSource Audio;
    /*[SerializeField]AudioClip WoodFloor1;
    [SerializeField] private AudioClip WoodFloor2;
    [SerializeField] private AudioClip WoodFloor3;
    [SerializeField] AudioClip IronFloor1;
    [SerializeField] private AudioClip IronFloor2;
    [SerializeField] private AudioClip IronFloor3;
    [SerializeField] AudioClip GrassFloor1;
    [SerializeField] private AudioClip GrassFloor2;
    [SerializeField] private AudioClip GrassFloor3;*/


    [SerializeField] AudioClip[] WoodFloor;
    [SerializeField] AudioClip[] IronFloor;
    [SerializeField] AudioClip[] GrassFloor;


    public void PlayAudio(FloorMaterial Material)
    {

        
        switch (Material)
        {
            case FloorMaterial.WoodFloor:   
                
                Audio.PlayOneShot(WoodFloor[Random.Range(0, WoodFloor.Length)]);
                Debug.Log("PlayOneShotWOODFLOOR");
                break;


            case FloorMaterial.IronFloor:
                
                Audio.PlayOneShot(IronFloor[Random.Range(0, IronFloor.Length)]);
                Debug.Log("PlayOneShotIRONFLOOR");
                break;


            case FloorMaterial.GrassFloor:
                
                Audio.PlayOneShot(GrassFloor[Random.Range(0, GrassFloor.Length)]);
                Debug.Log("PlayOneShotGRASSFLOOR");
                break;

            default:
               
                Audio.PlayOneShot(WoodFloor[Random.Range(0, WoodFloor.Length)]);
                Debug.Log("–¿¡Œ“¿≈“");
                break;
        }       

    }


    public void PlayDefAudio(string name)
    {
        Audio.PlayOneShot(WoodFloor[1]);
        Debug.LogError($"GameObject {name} NET MATERIALA IDIOT");
    }

}
