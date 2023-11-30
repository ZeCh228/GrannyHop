using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
 
    public float elasticityCoefficient = 1.0f; // коэффициент упругости, можно настроить в инспекторе
    public float gravity = 9.83f; // гравитация

    private float initialHeight; // начальная высота погостика перед отскоком

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
        // Получить текущую высоту и нормаль поверхности под погостиком
        float currentHeight = transform.position.y;
        Vector3 surfaceNormal = GetSurfaceNormal();

        // Рассчитать силу отскока
        float bounceForce = CalculateBounceForce(currentHeight, surfaceNormal);
        Debug.Log("BF " + bounceForce);
        // Применить гравитацию
        /*Vector3 gravityForce = Vector3.down * gravity * rb.mass;
        rb.AddForce(gravityForce);*/

        // Применить силу отскока
        //TODO: fixupdate
        rb.AddForce(bounceForce * surfaceNormal, ForceMode.Force);
    }

    private float CalculateBounceForce(float currentHeight, Vector3 surfaceNormal)
    {
        float bounceForce = elasticityCoefficient/* * (currentHeight - initialHeight)*/;
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




