using UnityEngine;

public class PCInput : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public CameraRotation cameraRotation;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"));
        Debug.Log(direction);
        PlayerMovement.Rotate(direction); 
        cameraRotation.Rotate(direction);
    }
}

