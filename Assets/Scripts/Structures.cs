using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Structures : MonoBehaviour
{
    //[SerializeField] GameObject[] Enemies;   
    [SerializeField] int SumNumbers;//тут будет хранитbся вся сумма массива первого задания



    private void Start()
    {
        //int[] numbers = { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };
        /*foreach (int number in numbers)
        {
            SumNumbers += number;
        }
        Debug.Log(SumNumbers); //1




       int[] numbers = { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };

        int Max = numbers[1];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > Max)
            {
                Max = numbers[i];
            }

        }
        Debug.Log(Max);*/




        /*   int[] numbers = { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };
           int temp;

           for (int i = 0; i < numbers.Length; i++)
           {
               for(int a = 0; a < numbers.Length - 1 - i; a++) 
               {
                   if (numbers[a] == numbers[i + 1]) 
                   {
                   temp = numbers[a];
                       numbers[a] = numbers[a + 1];
                       numbers[a + 1] = temp;
                   }
               }
           }
           for(int i = 0; i < numbers.Length; i++) 
           {
               Debug.Log(numbers[i]);
           }

        
        var rand = new System.Random();
        int temp;
        int RandomNumber;
        int[] numbers = { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };
        for(int i = numbers.Length - 1; i > 0 ; i--) 
        { 
        RandomNumber = rand.Next(i + 1);
            temp = numbers[RandomNumber];
            numbers[RandomNumber] = numbers[i];
            numbers[i]= temp;
        }
        for (int i = 0; i < numbers.Length; i++) 
        {
            Debug.Log(numbers[i]);
        }*/
    } 
}

















/*int a = -5;
int b = 4;
int brecets = (a / b);
int result = a - brecets * b;
Debug.Log(result + "/" + brecets);

 for (int i = 0; i < Enemies.Length; i++)  //вывод массива в консоль
{
    Debug.Log(Enemies[i]);
 }


for (int i = Enemies.Length - 1; i >= 0; i--) //инверсия массива в консоли
{
     Debug.Log(Enemies[i]);

 }

 int EnemiesLength = Enemies.Length; //инверсия массива в инспекторе  
int HalfEnemyLength = EnemiesLength / 2;
 GameObject temp;
 for (int i = 0; i < HalfEnemyLength; i++)
 {
    temp = Enemies[i];
     Enemies[i] = Enemies[EnemiesLength - i - 1];
    Enemies[EnemiesLength - i - 1] = temp;
 }





for (int i = 0; i < Enemies.Length; i++) // дестрой четных 01
 {
     if (i % 2 != 0)
     {
        Destroy(Enemies[i]);
    }
 }*/


