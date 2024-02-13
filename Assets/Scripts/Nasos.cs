using MoreMountains.Feedbacks;
using System.Collections;
using UnityEngine;

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
    [SerializeField] MMF_Player MMF_Player;
    [SerializeField] Transform EffectTransform;
    public RaycastHit info;
    [SerializeField] GrannyAnimation GrannyAnimation;


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
                    AudioSystem?.PlayDefAudio(colliders[0].name);
                }
                PlayerMovement.Jump(JumpPower);
                GrannyAnimation?.LandingAnim();
                if (Physics.Raycast(spherePoint.position, spherePoint.TransformDirection(Vector3.down), out info, 20, groundLayer)) //TO DO FIX
                {
                    var Position = info.point;
                    var Rotation = info.normal;

                    EffectTransform.position = Position;


                    EffectTransform.rotation = Quaternion.LookRotation(Rotation, Vector3.forward);

                    MMF_Player?.PlayFeedbacks();
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





















