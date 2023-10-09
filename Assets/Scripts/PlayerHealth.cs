using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
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
        rb.position = SpawnPoint.position;
        rb.rotation = Quaternion.Euler(Vector3.zero);
        rb.velocity = Vector3.zero;

        Debug.Log("Stop2sec");        
    }
   

}
