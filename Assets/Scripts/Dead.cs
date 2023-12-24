using MoreMountains.Feedbacks;
using MoreMountains.FeedbacksForThirdParty;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Dead : MonoBehaviour
{
    [SerializeField] PlayerHealth PlayerHealth;
    [SerializeField] Nasos Nasos;
    [SerializeField] Transform EffectTransform;
    [SerializeField] MMF_Player MMF_Player;


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
            var Position = collider.ClosestPoint(collider.transform.position)  ;
            EffectTransform.position = Position;
            MMF_Player.PlayFeedbacks();
        }
    }
}
