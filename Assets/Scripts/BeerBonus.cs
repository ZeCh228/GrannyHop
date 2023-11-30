using UnityEngine;
using UnityEngine.UI;

public class BeerBonus : MonoBehaviour
{     

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
        }
    }   
}
