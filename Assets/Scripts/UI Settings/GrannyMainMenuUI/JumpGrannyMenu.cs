using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGrannyMenu : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool Ground;
    Rigidbody rb;
  
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0f, 5f, 0f);
    }
  
    
    void OnCollisionStay()
    {
        Ground = true;
    }
   
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Ground)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            Ground = false;
        }
    }
}
