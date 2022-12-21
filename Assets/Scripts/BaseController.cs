using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    protected void Fire()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
    }


    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(BulletSpawnPosition.transform.position,BulletSpawnPosition.transform.up,out hit))
        {
            Debug.DrawRay(BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.up * 20f);
            Fire();
        }
    }
}
