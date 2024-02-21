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
    [SerializeField] int CurrentLevel;
    [SerializeField] int UnlockLevel;

    private void Start()
    {
        UnlockLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
    }

    public void LoadLevel(int levelIndex)
    {
        if (levelIndex <= UnlockLevel)
        {
            SceneManager.LoadScene(levelIndex);
            CurrentLevel = levelIndex;
        }
        else
        {
            Debug.Log("Уровень закрыт, пройди прошлый");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (CurrentLevel == UnlockLevel && CurrentLevel < 8)
            {
                UnlockLevel++;
                PlayerPrefs.SetInt("UnlockLevel", UnlockLevel);
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


