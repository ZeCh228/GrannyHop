using UnityEngine;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] private int _minXRotation;
    [SerializeField] private int _maxXRotation;
    [SerializeField] float VerticalSensivity;
    [SerializeField] float HorizontalSensivity;
    [SerializeField] Transform target;
    [SerializeField] Transform camera;
    private float currentPitch;

    public void ResetRotation(float y)
    {
        currentPitch = 0;
        transform.rotation = Quaternion.Euler(0, y, 0);
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

