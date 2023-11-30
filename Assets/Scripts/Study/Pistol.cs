using System.Collections;
using UnityEngine;



public class Pistol : MonoBehaviour
{

    [SerializeField] Pool pool;
    [SerializeField] Transform BulletStarPoint;
    [SerializeField] float StartBulletSpeed;
    
   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)) 
        {
            var Bullet = pool.GetObject();
            Bullet.SetActive(true);
            Bullet.transform.position = BulletStarPoint.position; 
            Bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * StartBulletSpeed);
        }
    }
}
