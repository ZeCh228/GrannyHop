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
            //Time.timeScale = 0;
            //StartCoroutine(Wait());           
            transform.position = SpawnPoint.position;
            transform.eulerAngles = Vector3.zero;
            //Time.timeScale = 1;
            //rb.velocity = Vector3.zero;
            //rb.isKinematic = true;           
            //rb.isKinematic = false;
            //rb.useGravity = true;
        }
    }

    /*public IEnumerator Stop2sec() 
    {
        if(gameObject.CompareTag("Obstacle"))
    yield return new WaitForSeconds(2f);
        Debug.Log("Stop2sec");
    }*/

}
