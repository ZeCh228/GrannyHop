using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasos : MonoBehaviour
{
   //���

    public float JumpPower;
    public PlayerMovement PlayerMovement;

    int y;

    private void OnCollisionEnter(Collision collision) //��������
    {
        PlayerMovement.Jump(JumpPower);
        print("coll");
        Move();
    }

    private void Move()
    {
        int x;
        int z;
        int v;
        
    }

    private void Stay()
    {
    }


}
