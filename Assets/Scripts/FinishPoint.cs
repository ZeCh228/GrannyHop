using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] PlayerMovement Rotate;
    [SerializeField] PCInput PCInput;
    [SerializeField] MobileInput MobileInput;
    [SerializeField] CompleteLvlCanvas canvas;  
    [SerializeField] TimeStars TimeStars;  


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            rb.isKinematic = true;
            Rotate.enabled = false;
            PCInput.enabled = false;
            MobileInput.enabled = false;
            Debug.Log("Finish");

            canvas.EnableCanvas(TimeStars.GetTime(), TimeStars.CalculateStars());
        }

        
    }

}




//1) ���������, ��� ����� ������ ����� (����� �� ����) // ������
//2) ���� ��� �����, �� ��������� ��� �������, ������� ���������� // ������
//3) ���� (�� ������)