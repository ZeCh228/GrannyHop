using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] int countBulletToInstantiateOnInitiolize;
    [SerializeField] int countBulletToInstantiateOnExpand;

    Queue<GameObject> BulletQueue = new Queue<GameObject>();

    void Start()
    {
        PoolIniTialize();
    }

    public GameObject GetObject()
    {
        if (BulletQueue.Count == 0 )
        {
            PoolExpand();
        }    

        return BulletQueue.Dequeue();
    }

    private void PoolExpand()
    {
        var newObjects = CreateNewObjects(countBulletToInstantiateOnExpand);
        for (int i = 0; i < newObjects.Length; ++i)
        {
            BulletQueue.Enqueue(newObjects[i]);
        }
    }

    public void ReturnToPool(GameObject BulletPrefab)
    {      
        BulletQueue.Enqueue(BulletPrefab);
    }

    private GameObject[] CreateNewObjects(int Count) 
    {
        var GameObjects = new GameObject[Count];
        for (int i = 0; i < Count; i++)
        {
            var newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            newBullet.GetComponent<Bullet>().Initialize(this);
            newBullet.SetActive(false);

            GameObjects[i] = newBullet;
        }
        return GameObjects;
    }


    private void PoolIniTialize()
    {
        for (int i = 0; i < countBulletToInstantiateOnInitiolize; i++)
        {
            var newBullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            
            newBullet.GetComponent<Bullet>().Initialize(this);
            newBullet.SetActive(false);

            BulletQueue.Enqueue(newBullet);
        }
    }

}
