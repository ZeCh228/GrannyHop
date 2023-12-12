using MoreMountains.Tools;
using System.Linq;
using UnityEngine;

public class PCInput : MonoBehaviour
{
    public PlayerMovement PlayerMovement;
    public CameraRotation cameraRotation;
    public bool Inversion;
    Vector2 direction = Vector2.zero;
    
    
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    
    void Update()
    {
       

        if (Inversion) 
        {
             direction = new Vector2(Input.GetAxis("Mouse Y") * -1, Input.GetAxis("Mouse X"));
        }
        else 
        {
             direction = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"));
        }

       
        Debug.Log(direction);
        PlayerMovement.Rotate(direction); 
        cameraRotation.Rotate(direction);

        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerMovement.BlockRotationForFreeView();
            
            Debug.Log("GetKeyDown");
        }
        
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayerMovement.UnBlockRotationForFreeView();
            
            Debug.Log("GetKeyUp");
        }
    }
}

