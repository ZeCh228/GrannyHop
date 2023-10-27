using System;
using UnityEngine;
using UnityEngine.UIElements;

public class Structures : MonoBehaviour
{
    //[SerializeField] GameObject[] Enemies;   
    [SerializeField] int SumNumbers;//тут будет хранитbся вся сумма массива первого задания
    [SerializeField] int[] numbers;

    /// <summary>
    /// функция ищет число в массиве и возвращает True, если оно найдено и false, если не найдено
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    private bool Contains(int x)
    {
        for (int i = 0; i < x; i++) 
        {
            if (numbers[i] == x) 
            {
                return true;
            }            
        }
        return false;
        //1) создать цикл for, итерации должны пройти максимальное кол-во элементов в массиве или пока не найдёт число, которое ввёл пользователь (это то самое int x)
        //2) проверить если: нужно обратиться сначала к массиву, затем к элементу массива[i] и сравнить его на строгое равенство с int x
        //3) если проверка true, то в этом случае return true
        //4) если проверка false, то цикл продолжится
        //5) если цикл закончился ни разу не вернув true, то return false !!!ПОСЛЕ ЦИКЛА!!!        
    }




    private void Start()
    {
        numbers = new int[] { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };

        bool res1, res2, res3;

        res1 = Contains(-15);
        print($"-15 | {res1}");

        res2 = Contains(10);
        print($"10 | {res2}");

        res3 = Contains(0);
        print($"10 | {res3}");


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
        Debug.Log(Max);




           int[] numbers = { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };
           int temp;

           for (int i = 0; i < numbers.Length; i++)
           {
               for(int a = 0; a < numbers.Length - 1 - i; a++) 
               {
                   if (numbers[a] < numbers[i + 1]) 
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


        /*var rand = new System.Random();
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
           
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            Add(228);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            DeleteAt(0);
        }
    }

    private void DeleteAt(int y)
    {
        var NewArrayDel = new int[numbers.Length - 1];
        for (int i = 0; i < y; i++) 
        {            
            NewArrayDel[i] = numbers[i];
        }
        for (int i = y + 1; i < numbers.Length; i++) 
        {
            NewArrayDel[i - 1] = numbers[i];
        }
        numbers = NewArrayDel;
    }
     
    private void Add(int x)
    {
        var NewArray = new int[numbers.Length + 1] ;
        for (int i = 0;  i < numbers.Length; i++) 
        {
            NewArray[i] = numbers[i];
        }
        NewArray[NewArray.Length - 1] = x;
        numbers = NewArray;
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


