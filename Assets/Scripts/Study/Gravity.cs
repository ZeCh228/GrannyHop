using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField] Transform PlanetGravity;
    [SerializeField] float gravity = 9.81f;
    Vector3 a;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        CalculGravity();
    }

    private void CalculGravity() 
    {
        a = transform.position - PlanetGravity.position;
        rb.AddForce( - a.normalized * gravity * rb.mass);
    }
}