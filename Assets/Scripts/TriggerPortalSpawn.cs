using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerPortalSpawn : MonoBehaviour
{
   [SerializeField] MMF_Player MMF_Player;  


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MMF_Player.PlayFeedbacks();            
        }
    }
}

