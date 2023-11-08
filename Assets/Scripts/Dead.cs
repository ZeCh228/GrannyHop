using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dead : MonoBehaviour
{
    [SerializeField] PlayerHealth PlayerHealth;

    private void OnValidate()
    {      
        if(PlayerHealth == null) 
        {
            PlayerHealth = FindObjectOfType<PlayerHealth>();            
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player")) 
        {
            PlayerHealth.DeadRespawn();
        }
    }
}
