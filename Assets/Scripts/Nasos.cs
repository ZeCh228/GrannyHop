using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasos : MonoBehaviour
{
   //���

    public float JumpPower;
    public PlayerMovement PlayerMovement; 



    private void OnCollisionEnter(Collision collision) //��������
    {
        PlayerMovement.Jump(JumpPower);
        print("coll");
    }
}
