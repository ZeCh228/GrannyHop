using MoreMountains.Feedbacks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour 
{
    public Rigidbody rb;
    [SerializeField] PlayerMovement Rotate;
    [SerializeField] PCInput PCInput;
    [SerializeField] MobileInput MobileInput;
    [SerializeField] CompleteLvlCanvas canvas;
    [SerializeField] TimeStars TimeStars;
    [SerializeField] DissolvePortal DissolvePortal;
    [SerializeField] Nasos Nasos;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var SceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            
            if (SceneIndex > PlayerPrefs.GetInt("level"))
            {
                PlayerPrefs.SetInt("level", SceneIndex);
            }

             Nasos.enabled = false;
             rb.isKinematic = true;
             Rotate.enabled = false;
             PCInput.enabled = false;
             MobileInput.enabled = false;             

             DissolvePortal.StartDissolve();

             canvas.EnableCanvas(TimeStars.GetTime()); /*TimeStars.CalculateStars()*/
        }
    }
}


