using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Structures : MonoBehaviour
{
    [SerializeField] GameObject[] Enemies;




    private void Start()
    {

        int a = -5;
        int b = 4;
        int brecets = (a / b);
        int result = a - brecets * b;
        Debug.Log(result + "/" + brecets);

        // for (int i = 0; i < Enemies.Length; i++)  //����� ������� � �������
        //{
        //    Debug.Log(Enemies[i]);
        // }


        //for (int i = Enemies.Length - 1; i >= 0; i--) //�������� ������� � �������
        //{
        //     Debug.Log(Enemies[i]);

        // }

        // int EnemiesLength = Enemies.Length; //�������� ������� � ����������  
        //int HalfEnemyLength = EnemiesLength / 2;
        // GameObject temp;
        // for (int i = 0; i < HalfEnemyLength; i++)
        // {
        //    temp = Enemies[i];
        //     Enemies[i] = Enemies[EnemiesLength - i - 1];
        //    Enemies[EnemiesLength - i - 1] = temp;
        // }





        //for (int i = 0; i < Enemies.Length; i++) // ������� ������ 01
        // {
        //     if (i % 2 != 0)
        //     {
        //         Destroy(Enemies[i]);
        //    }
        // }

        //  }
    }
}
