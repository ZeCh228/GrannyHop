using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrannyAnimation : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator Anim;


    void Update()
    {
        Anim.SetFloat("VelocityY", rb.velocity.y);
       
    }

    public void LandingAnim()
    {
        Anim.SetTrigger("TriggerLanding");
    }
}
