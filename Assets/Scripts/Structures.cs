using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Structures : MonoBehaviour
{
    [SerializeField] GameObject[] Enemies;




    private void Start()
    {
        /*for (int i = 0; i < Enemies.Length; i++)  //вывод массива в консоль
        {
            Debug.Log(Enemies[i]);
        }

        
        for (int i = Enemies.Length - 1; i >= 0; i--) //инверсия массива в консоли
        {
            Debug.Log(Enemies[i]);
        
        
        int EnemiesLength = Enemies.Length; //инверсия массива в инспекторе  
        int HalfEnemyLength = EnemiesLength / 2;
        GameObject temp;
        for (int i = 0; i < HalfEnemyLength; i++) 
        {
            temp = Enemies[i];
            Enemies[i] = Enemies[EnemiesLength - i - 1];
            Enemies[EnemiesLength - i - 1] = temp;
        }
        




        for (int i = 0; i < Enemies.Length; i++) // дестрой четных 
        {
            if (i % 2 == 0) 
            {               
                Destroy(Enemies[i]);
            }
        }
        */
    }
}
