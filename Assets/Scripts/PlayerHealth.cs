using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] Rigidbody rb;
    [SerializeField] Rigidbody NasosRB;

    private void OnCollisionEnter(Collision collision) 
    {        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            print($"Collision With {collision.gameObject.name}");
            //Time.timeScale = 0f;
            StartCoroutine(Wait());            
        }
    }
    IEnumerator Wait()
    {        
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;                
       transform.position = SpawnPoint.position;
        transform.rotation = Quaternion.Euler(Vector3.zero);
        rb.velocity = Vector3.zero;
        NasosRB.velocity = Vector3.zero;

        Debug.Log("Stop2sec");        
    }  
}
