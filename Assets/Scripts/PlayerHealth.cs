using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] Rigidbody playerRb, nasos;

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
        transform.rotation = Quaternion.Euler(Vector3.zero);
        playerRb.velocity = Vector3.zero;
        nasos.velocity = Vector3.zero;

        Debug.Log("Stop2sec");        
    }
   

}
