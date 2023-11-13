using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasos : MonoBehaviour
{   
    public float JumpPower;
    public PlayerMovement PlayerMovement;
    [SerializeField] Transform spherePoint;
    [SerializeField] float sphereRadius;
    [SerializeField] LayerMask groundMask;
       
    private void FixedUpdate()
    {
        var colliders = Physics.OverlapSphere(spherePoint.position, sphereRadius, groundMask);

        if (colliders.Length > 0)
        {
            PlayerMovement.Jump(JumpPower);
        }
    }



    
    
    
}
    /*public Rigidbody rb;
    [SerializeField] float Elastic = 1f;
    [SerializeField] float Gravity = 10f;
    [SerializeField] float DefaultHeight = 1f;

    private void Start()
    {
        DefaultHeight = transform.position.y;

    }

    private void Update()
    {
        float CurrentHeight = transform.position.y;
        Vector3 Normalii = Normal();
    }

    private Vector3 Normal() 
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down,out hit)) 
        {
            return hit.normal;
        }
        return Vector3.up;
    }*/

