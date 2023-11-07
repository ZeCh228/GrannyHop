using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private CameraRotation LookAt;
    [SerializeField] private PlayerMovement Movement;
    [SerializeField] Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;
        transform.position = SpawnPoint.position;
        Movement.ResetRotation(SpawnPoint.eulerAngles.y);
        LookAt.ResetRotation(SpawnPoint.eulerAngles.y);
        
        rb.velocity = Vector3.zero;
    }
}
