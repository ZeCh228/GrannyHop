using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] int countBulletToInstantiate;

    Queue<GameObject> BulletQueue = new Queue<GameObject>();

    void Start()
    {
        PoolIniTialize();
    }

    public GameObject GetObject() 
    {
     
        return BulletQueue.Dequeue();
    }

    public void ReturnToPool(GameObject BulletPrefab) 
    {
        Debug.Log("odsjofd");
        BulletQueue.Enqueue(BulletPrefab);
    } 




    private void PoolIniTialize()
    {
        for (int i = 0; i < countBulletToInstantiate; i++)
        {
            var newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            
            newBullet.GetComponent<Bullet>().Initialize(this);
            newBullet.SetActive(false);

            BulletQueue.Enqueue(newBullet);
        }
    }

}
