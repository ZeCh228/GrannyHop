using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class BeerBonus : MonoBehaviour
{

    [SerializeField] ParticleSystem ParticleSystem;
    [SerializeField] AudioSource AudioSource;

    private void Update()
    {        
        if (Time.timeScale > 0) 
        {
            transform.Rotate(0, 1, 0);
        }

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.GetComponent<PlayerBeerScore>().AddBeer();
            Destroy(gameObject);
            ParticleSystem.gameObject.SetActive(true);
            ParticleSystem.transform.parent = null;
            AudioSource.enabled = true;
            AudioSource.Play();
        }
    }   
}
