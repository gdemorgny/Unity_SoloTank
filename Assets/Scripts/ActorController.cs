using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    [SerializeField] protected int LifePoint = 1;
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected float DelayValue = 2f;
    // Start is called before the first frame update
    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
    }
}
