using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float VerticalSensivity;
    public float HorizontalSensivity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //Vector2 rot = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        //Rotate(rot.normalized * Sensivity);
    }

    public void Jump(float Power)
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.AddForce(transform.up * Power, ForceMode.VelocityChange); //режимы силы 
    }

    public void Rotate(Vector2 FingerDirection)
    {
        float x = transform.eulerAngles.x + FingerDirection.x * (VerticalSensivity * Time.deltaTime);
        float y = transform.eulerAngles.y + FingerDirection.y * (HorizontalSensivity * Time.deltaTime);
        transform.eulerAngles = new Vector3(x, y, 0);
    }
}

