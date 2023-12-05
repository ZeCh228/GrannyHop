using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _minXRotation;
    [SerializeField] private int _maxXRotation;
    [Range(0,1)][SerializeField] private float _accelerationReducer;
    
    
    public Rigidbody rb;
    public float VerticalSensivity;
    public float HorizontalSensivity;
    private float currentPitch;
    private float TotalSensivity;

    
    public void SettingsSet(float Sensivity)
    {
        TotalSensivity = Sensivity;
        VerticalSensivity *= TotalSensivity;
        HorizontalSensivity *= TotalSensivity;
    }


    public void ResetRotation(float y)
    {
        currentPitch = 0;
        transform.rotation = Quaternion.Euler(0,y,0);
    }

   
    public void Jump(float Power)
    {
        //rb.velocity = new Vector3(0, 0, 0);
        // rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.velocity = new Vector3(rb.velocity.x * _accelerationReducer, 0, rb.velocity.z * _accelerationReducer);
        
        rb.AddForce(transform.up * Power, ForceMode.VelocityChange);
        DebugDirections.Instance.EndDirections.Add(transform.up * 2);
    }

   
    public void Rotate(Vector2 direction)
    {
        float y = transform.eulerAngles.y + direction.y * (HorizontalSensivity * Time.deltaTime);
        float rotationInputX = direction.x * VerticalSensivity * Time.deltaTime;
        currentPitch -= rotationInputX;
        currentPitch = Mathf.Clamp(currentPitch, _minXRotation, _maxXRotation);

        Quaternion rotation = Quaternion.Euler(currentPitch, y, 0);
        transform.rotation = rotation;
    }   
}




