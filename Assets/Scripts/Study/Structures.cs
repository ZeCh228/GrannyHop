using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class Structures : MonoBehaviour
{
    //[SerializeField] GameObject[] Enemies;   
    [SerializeField] int SumNumbers;//��� ����� ������b�� ��� ����� ������� ������� �������
    [SerializeField] int[] numbers;

    [SerializeField] string password;
    [SerializeField] string userInput;
    /// <summary>
    /// ������� ���� ����� � ������� � ���������� True, ���� ��� ������� � false, ���� �� �������
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    private bool Contains(int x)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == x)
            {
                return true;
            }
        }
        return false;
        //1) ������� ���� for, �������� ������ ������ ������������ ���-�� ��������� � ������� ��� ���� �� ����� �����, ������� ��� ������������ (��� �� ����� int x)
        //2) ��������� ����: ����� ���������� ������� � �������, ����� � �������� �������[i] � �������� ��� �� ������� ��������� � int x
        //3) ���� �������� true, �� � ���� ������ return true
        //4) ���� �������� false, �� ���� �����������
        //5) ���� ���� ���������� �� ���� �� ������ true, �� return false !!!����� �����!!!        
    }




    private (float, Vector3) CalculateJump2() 
    {
        return (10.5f, Vector3.zero);
    }


    private void CalculateJump(out float force, out Vector3 direction)
    {
        direction = Vector3.zero;
        force = 0f;
    }

    private void ApplyJumpForce(float force, Vector3 direction, int x = 0 )
    {

    }

    private void Start()
    {
        float force = 0;
        Vector3 direction = Vector3.zero;
        CalculateJump(out  force, out  direction);
        ApplyJumpForce(force, direction, 20);
            

        


        numbers = new int[] { 1, 25, 4, 5, 9, 10, 8, 4, -1, 0 };

        bool res1, res2, res3;

        res1 = Contains(-15);
        print($"-15 | {res1}");

        res2 = Contains(10);
        print($"10 | {res2}");

        res3 = Contains(0);
        print($"10 | {res3}");

        if (ReferenceEquals(password, userInput))
        {
            print("Unlock!");
        }

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
        int x = 5 * (int)proverka.global;
        print(x);
    }


}

public enum proverka
{
    global = 10
}















/*int a = -5;
int b = 4;
int brecets = (a / b);
int result = a - brecets * b;
Debug.Log(result + "/" + brecets);

 for (int i = 0; i < Enemies.Length; i++)  //����� ������� � �������
{
    Debug.Log(Enemies[i]);
 }


for (int i = Enemies.Length - 1; i >= 0; i--) //�������� ������� � �������
{
     Debug.Log(Enemies[i]);

 }

 int EnemiesLength = Enemies.Length; //�������� ������� � ����������  
int HalfEnemyLength = EnemiesLength / 2;
 GameObject temp;
 for (int i = 0; i < HalfEnemyLength; i++)
 {
    temp = Enemies[i];
     Enemies[i] = Enemies[EnemiesLength - i - 1];
    Enemies[EnemiesLength - i - 1] = temp;
 }





for (int i = 0; i < Enemies.Length; i++) // ������� ������ 01
 {
     if (i % 2 != 0)
     {
        Destroy(Enemies[i]);
    }
 }*/


