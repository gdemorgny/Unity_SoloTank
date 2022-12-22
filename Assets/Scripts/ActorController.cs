using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    [SerializeField] protected int LifePoint = 1;
    [SerializeField] protected GameObject BulletPrefab;
    [SerializeField] protected GameObject BulletSpawnPosition;
    [SerializeField] protected float DelayValue = 2f;
    [SerializeField] protected GameObject _head;
    private bool _isArleadyFiring = false;
    // Start is called before the first frame update
    protected void Fire()
    {
        if (!_isArleadyFiring)
        {
            _isArleadyFiring = true;
            StartCoroutine(FireWithDelay());

        }
    }

    protected void RotateHeadTo(Vector3 targetPosition)
    {
        _head.transform.LookAt(targetPosition);
    }

    IEnumerator FireWithDelay()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);

        yield return new WaitForSeconds(DelayValue);
        
        _isArleadyFiring = false;
    }
}
