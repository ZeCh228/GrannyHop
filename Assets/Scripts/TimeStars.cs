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
        var StarsCount = 0; //��������� ���������� �� ������� ���, �� ���� ������ � ��������

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
    /*��������� ������ �������� ���-�� ����, ��� ����� ������ ������� 1 ������
    � ����� ���� ������� ������� ������ 15 ���, �� ��� ������, ���� ������, �� 3
    � ����� ������ �������� �����, ����� �������, �� �������� �� ������ �������� �����
    �� ���� ������ � ��������)*/

    public float GetTime()
    {
        time = Time.timeSinceLevelLoad;
        return time;
    }
}
