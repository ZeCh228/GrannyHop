using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompleteLvlCanvas : MonoBehaviour
{
    [SerializeField] GameObject[] Stars;
    [SerializeField] TextMeshProUGUI Time;
    

    public void EnableCanvas(float time, int stars) 
    {
        Time.SetText(time.ToString());

        for(int i = 0; i < stars; i++) 
        {
            Stars[i].SetActive(true);
        }
    }
}
