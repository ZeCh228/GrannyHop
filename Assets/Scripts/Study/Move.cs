using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 1f;
    private Rigidbody rb;
    Vector3 MoveVector; 


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


     void Update()
     {
         MoveVector.x = Input.GetAxis("Horizontal"); 
         MoveVector.y = Input.GetAxis("Vertical"); 
         rb.MovePosition(rb.position + MoveVector * MoveSpeed * Time.deltaTime);
     }
}
