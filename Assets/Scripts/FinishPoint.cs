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
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            rb.isKinematic = true;
            Rotate.enabled = false;
            PCInput.enabled = false;
            MobileInput.enabled = false;
            Debug.Log("Finish");
        }

        
    }

}




//1) проверить, что вошёл именно игрок (можно по тегу) // сделал
//2) если это игрок, то отключаем упр игроком, убираем прыгучесть // сделал
//3) меню (не делать)