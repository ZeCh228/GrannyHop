using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int _minXRotation;
    [SerializeField] private int _maxXRotation;
    [SerializeField] private float _accelerationReducer;
    public Rigidbody rb;
    public float VerticalSensivity;
    public float HorizontalSensivity;
    private float currentPitch;


    public void ResetRotation(float y)
    {
        currentPitch = 0;
        transform.rotation = Quaternion.Euler(0,y,0);
    }

    public void Jump(float Power)
    {
        rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
        rb.AddForce(transform.up * Power, ForceMode.VelocityChange);
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

















    public float elasticityCoefficient = 1.0f; // коэффициент упругости, можно настроить в инспекторе
    public float gravity = 9.83f; // гравитаци€

    private float initialHeight; // начальна€ высота погостика перед отскоком

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        initialHeight = transform.position.y; // сохранить начальную высоту
    }

    private void Update()
    {
        // ѕолучить текущую высоту и нормаль поверхности под погостиком
        float currentHeight = transform.position.y;
        Vector3 surfaceNormal = GetSurfaceNormal();

        // –ассчитать силу отскока
        float bounceForce = CalculateBounceForce(currentHeight, surfaceNormal);

        // ѕрименить гравитацию
        Vector3 gravityForce = Vector3.down * gravity /** rb.mass*/;
        rb.AddForce(gravityForce);

        // ѕрименить силу отскока
        //TODO: fixupdate
        rb.AddForce(bounceForce * surfaceNormal, ForceMode.Force);
    }

    private float CalculateBounceForce(float currentHeight, Vector3 surfaceNormal)
    {
        float bounceForce = elasticityCoefficient * (currentHeight - initialHeight);
        return bounceForce;
    }

    private Vector3 GetSurfaceNormal()
    {
        //TODO: check

        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit))
        {
            return hit.normal;
        }

        return Vector3.up; // возвращаем вектор вверх, если не удалось определить нормаль
    }
}

