using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamUserStats : MonoBehaviour
{
    private int _currentClicks;
    private int _oneClick = 1;

    void Start()
    {
        GetUserStat("ClickCount");
        SetUserStat("ClickCount");
        SoreUserStat();
    }

    private void SoreUserStat()
    {
        throw new NotImplementedException();
    }

    private void SetUserStat(string StatName)
    {
        throw new NotImplementedException();
    }

    private void GetUserStat(string StatName)
    {
       bool _isStatRecived = Steamworks.SteamUserStats.GetStat(StatName, out _currentClicks);

        Debug.Log("Recived stat" + _isStatRecived);
        Debug.Log("Stat data" + _currentClicks);
    }
}
