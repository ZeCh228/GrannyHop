using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] private int _minXRotation;
    [SerializeField] private int _maxXRotation;
    [SerializeField] float BaseVerticalSensivity;
    [SerializeField] float BaseHorizontalSensivity;    
    [SerializeField] Transform target;   
    
    private float TotalSensivity;
    private float currentPitch;
    private float CurrentHorizontalSensivity;
    private float CurrentVerticalSensivity;

    public void SettingsSet(float Sensivity) 
    {

        TotalSensivity = Sensivity;
        CurrentHorizontalSensivity = BaseHorizontalSensivity * TotalSensivity;
        CurrentVerticalSensivity = BaseVerticalSensivity * TotalSensivity;
        
    }


    public void ResetRotation(float y)
    {
        currentPitch = 0;
        transform.rotation = Quaternion.Euler(0, y, 0);
    }


    public void Rotate(Vector2 direction)
    {
        float y = transform.eulerAngles.y + direction.y * (CurrentHorizontalSensivity * Time.deltaTime);
        float rotationInputX = direction.x * CurrentVerticalSensivity * Time.deltaTime;
        currentPitch -= rotationInputX;
        currentPitch = Mathf.Clamp(currentPitch, _minXRotation, _maxXRotation);

        Quaternion rotation = Quaternion.Euler(currentPitch, y, 0);
        transform.rotation = rotation;
    }
}

