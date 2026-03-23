using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// La pool l'ho fatta specifica per I proiettili, volendo tramite dictionary e un enum PoolID fare diverse Pool
public class PoolBullet : Singleton<PoolBullet>
{
    [SerializeField] private BulletTurret prefab;
    [SerializeField] private int sizePool=50;
    [SerializeField] private int numEmergercy=20;
    private Queue<BulletTurret> pool = new Queue<BulletTurret>();
    protected override void Awake()
    {
        base.Awake();
        CreatePool(sizePool);
    }
    public void CreatePool(int numPrefab)
    {
        for (int i = 0; i < numPrefab; ++i)
        {
            var obj = Instantiate(prefab, transform);
            obj.gameObject.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    public BulletTurret GetPrefab()
    {
        if (pool.Count == 0)
        {
            CreatePool(numEmergercy);
        }
        var obj = pool.Dequeue();
        obj.gameObject.SetActive(true);
        return obj;
    }
    public void ReturnToPool(BulletTurret obj)
    {
        obj.gameObject.SetActive(false);
        pool.Enqueue(obj);
    }
}
