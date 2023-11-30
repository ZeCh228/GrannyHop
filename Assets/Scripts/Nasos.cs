using Cinemachine.Utility;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.ProBuilder;
using static UnityEditor.PlayerSettings;

public class Nasos : MonoBehaviour
{   
    public float JumpPower;
    public PlayerMovement PlayerMovement;
    [SerializeField] Transform spherePoint;
    [SerializeField] float sphereRadius;
    [SerializeField] LayerMask groundMask;
    [SerializeField] AudioSystem AudioSystem;
    [SerializeField] float JumpReload;
    private bool IsJumpAllowed = true;
    [SerializeField] LayerMask groundLayer;

    private void FixedUpdate()
    {
        if (IsJumpAllowed) 
        {
            var colliders = Physics.OverlapSphere(spherePoint.position, sphereRadius, groundMask);

            if (colliders.Length > 0)
            {
                if (colliders[0].TryGetComponent(out FloorMaterialVoice floorMaterialVoice))
                {
                    AudioSystem.PlayAudio(floorMaterialVoice.FloorMaterial);
                }
                else
                {
                    AudioSystem.PlayDefAudio(colliders[0].name);
                }
                PlayerMovement.Jump(JumpPower);

                if (Physics.Raycast(transform.position,Vector3.down,out RaycastHit info, 20, groundLayer))
                {
                    DebugDirections.Instance.StartDirections.Add(info.point);                    
                }

                
                StartCoroutine(JumpCoolDown());
            }
        }       
    }

    private IEnumerator JumpCoolDown() 
    {
        IsJumpAllowed = false;
        yield return new WaitForSeconds(JumpReload);
        IsJumpAllowed = true;
    }

    
    
    
}





















