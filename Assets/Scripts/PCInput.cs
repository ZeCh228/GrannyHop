using UnityEngine;

public class PCInput : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"));
        PlayerMovement.Rotate(direction);
    }
}

