using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamLicenseChecker : MonoBehaviour
{
    private void Start()
    {
        CheckLicense();
    }

    private void CheckLicense()
    {
        if(SteamManager.Initialized) 
        {
            Debug.Log("PlayerHasLicense");
        }
        else 
        {
            Debug.Log("CheckConnection");
        }
    }
}
