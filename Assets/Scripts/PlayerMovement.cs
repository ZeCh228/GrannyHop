using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public void Jump(float Power) 
    {
        rb.AddForce(transform.up * Power); //режимы силы 

    }

}
   //закон деметрии
