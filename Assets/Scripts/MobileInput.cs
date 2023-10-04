using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MobileInput : MonoBehaviour
{
    public Vector2 StartTouch;
    public Vector2 EndTouch;
    public Vector2 FingerDirection;
    public PlayerMovement PlayerMovement;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            print("Touch");
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                StartTouch = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                EndTouch = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Stationary)
            {
                StartTouch = Input.GetTouch(0).position;
                EndTouch = Input.GetTouch(0).position;
            }

            var direction = (EndTouch - StartTouch).normalized;
            FingerDirection = new Vector2(direction.y * -1, direction.x);
            PlayerMovement.Rotate(FingerDirection);
        }

    }
}

