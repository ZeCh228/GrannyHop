using MoreMountains.Feedbacks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMMPLAYER : MonoBehaviour
{
    [SerializeField] MMF_Player player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.PlayFeedbacks();  
        }
    }
}
