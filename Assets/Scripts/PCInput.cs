using UnityEngine;

public class PCInput : MonoBehaviour
{
    public PlayerMovement PlayerMovement;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"));
        PlayerMovement.Rotate(direction);
    }
}

