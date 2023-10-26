using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompleteLvlCanvas : MonoBehaviour
{
    [SerializeField] GameObject[] Stars;
    [SerializeField] TextMeshProUGUI Time;
    [SerializeField] GameObject Canvas;
    private void Start()
    {
        for (int i = 0; i < Stars.Length; i++)
        {
            Stars[i].SetActive(false);
        }
        Canvas.SetActive(false);
    }

    public void EnableCanvas(float time, int stars) 
    {
        Canvas.SetActive(true);
        Time.SetText(time.ToString());

        for(int i = 0; i < stars; i++) 
        {
            Stars[i].SetActive(true);
        }
    }
}
