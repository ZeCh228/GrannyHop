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
        var StarsCount = 1; //��������� ���������� �� ������� ���, �� ���� ������ � ��������

        var result = time - MiddleTime;

        if (result > 15)
        {
            StarsCount = 2;
        }
        else if (result < -15)
        {
            StarsCount = 3;
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
