using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float CoroutinePause = 0.5f;
    [SerializeField] private Transform SpawnPoint;
    [SerializeField] private CameraRotation LookAt;
    [SerializeField] private PlayerMovement Movement;
    [SerializeField] Rigidbody rb;
    [SerializeField] int PlayerDead;
    [SerializeField] TextMeshProUGUI DeadUI;
    [SerializeField] int DeadCountUiStart;
    [SerializeField] Animation AnimationDeadUI;
    [SerializeField] AudioSystem AudioSystem;


    private void Start()
    {
        Spawn();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (collision.gameObject.TryGetComponent(out FloorMaterialVoice floorMaterialVoice))
            {
                AudioSystem.PlayAudio(floorMaterialVoice.FloorMaterial);
            }
            else
            {
                AudioSystem.PlayDefAudio(collision.gameObject.name);
            }
            
            DeadRespawn();
        }
    }
    

    public void DeadRespawn() 
    {
        PlayerDead += 1;
        DeadAnimationCount();
        DeadUI.SetText(PlayerDead.ToString());
        StartCoroutine(Wait());
    }


    IEnumerator Wait()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(CoroutinePause);
        Time.timeScale = 1f;
        Spawn();
    }


    private void DeadAnimationCount()
    {
        if (PlayerDead % DeadCountUiStart==0) 
        {
            AnimationDeadUI.Play("New Animation");
        }
    }



    private void Spawn()
    {
        transform.position = SpawnPoint.position;
        Movement.ResetRotation(SpawnPoint.eulerAngles.y);
        LookAt.ResetRotation(SpawnPoint.eulerAngles.y);

        rb.velocity = Vector3.zero;
    }
}
