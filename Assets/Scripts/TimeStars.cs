using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStars : MonoBehaviour
{
    private float time;
    [SerializeField] float MiddleTime;
   
    public int CalculateStars() 
    {
        GetTime();
        var StarsCount = 1;
        if(time - MiddleTime > 15) 
        {
            return StarsCount;
        }
        else if(time - MiddleTime < -15) 
        {
            return StarsCount = 3;
        }
        else 
        {
            return StarsCount = 2;
        }        
    }

    public float GetTime()
    {
        time = Time.timeSinceLevelLoad;
        return time;
    }
}
