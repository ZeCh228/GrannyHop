using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStars : MonoBehaviour
{
    private float time;
    [SerializeField] float MiddleTime;
    [SerializeField] float AdditionalTime = 10;

    public int CalculateStars()
    {
        GetTime();
        var StarsCount = 0; //уменьшить арифметику не понимаю как, не стал писать в выходной

        //var result = time - MiddleTime;

        if (time < MiddleTime)
        {
            StarsCount = 3;
        }
        else if (time > MiddleTime+AdditionalTime)
        {
            StarsCount = 1;
        }
        else 
        {
            StarsCount = 2;
        }

        return StarsCount;
    }
    /*установил дефолт значение кол-во звёзд, ибо игрок всегда получит 1 звезду
    и затем если уровень пройден дольше 15 сек, то две звезды, если меньше, то 3
    в конце вернул значение ретёрн, может неверно, но сократил до одного значения ретёрн
    не стал писать в выходной)*/

    public float GetTime()
    {
        time = Time.timeSinceLevelLoad;
        return time;
    }
}
