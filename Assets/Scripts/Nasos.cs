using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasos : MonoBehaviour
{
   //„ËÚ

    public float JumpPower;
    public PlayerMovement PlayerMovement; 



    private void OnCollisionEnter(Collision collision) //ÕŒ–Ã¿À»»
    {
        PlayerMovement.Jump(JumpPower);
        print("coll");
    }
}
