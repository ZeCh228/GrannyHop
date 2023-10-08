using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Transform SpawnPoint;
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision) 
    {
        
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Time.timeScale = 0f;
            StartCoroutine(Wait());
            
            //transform.position = SpawnPoint.position;
            //transform.eulerAngles = Vector3.zero;
            //Time.timeScale = 1;
            //rb.velocity = Vector3.zero;
            //rb.isKinematic = true;           
            //rb.isKinematic = false;
            //rb.useGravity = true;
        }
    }
    IEnumerator Wait()
    {        
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1f;
        transform.position = SpawnPoint.position;
        transform.eulerAngles = Vector3.zero;
        Debug.Log("Stop2sec");        
    }

    /*public IEnumerator Wait() 
    {
        //if(gameObject.CompareTag("Obstacle"))
    yield return new WaitForSeconds(2f);

        transform.position = SpawnPoint.position;
        transform.eulerAngles = Vector3.zero;
        Debug.Log("Stop2sec");
    }*/

}
