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

/*
    private void OnCollisionEnter(Collision collision) //ÕŒ–Ã¿À»»
    {
        PlayerMovement.Jump(JumpPower);
        print("coll");
    }*/
}
