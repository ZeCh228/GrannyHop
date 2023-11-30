using System.Collections;
using System.Diagnostics.Tracing;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    [SerializeField] Pool pool;


    public void Initialize(Pool Parents)
    {
        pool = Parents; 
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision");
        pool.ReturnToPool(this.gameObject);
        gameObject.SetActive(false);
    }

}
