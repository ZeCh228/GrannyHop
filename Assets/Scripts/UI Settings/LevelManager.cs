using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public Button[] lvlButtons;

    void Start()
    {
        int level = PlayerPrefs.GetInt("level", 1);

        for (int i = 0; i < lvlButtons.Length; i++) 
        {
            if(i + 1 > level)
                lvlButtons[i].interactable = false;
        }
    } 

   
}
