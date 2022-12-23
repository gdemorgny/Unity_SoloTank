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
            StartCoroutine(FireWithDelay());
            _isArleadyFiring = true;

        }
    }

    protected void RotateHeadTo(Vector3 targetPosition)
    {
        _head.transform.LookAt(targetPosition);
    }

    // coroutine = nouveau thread
    // Appel de coroutine : StartCoroutine(<NomDeLIEnumerator>)
    IEnumerator FireWithDelay()
    {
        Instantiate<GameObject>(BulletPrefab, BulletSpawnPosition.transform.position, BulletSpawnPosition.transform.rotation);
        // yield return OBLIGATOIRE
        // d'autre yield return sont accessible dont WaitUntilEndOfFram.
        //Dans  notre cas nous voulons attendre un durée fixe : WaitForSeconds(<DelayD'attente>)
        yield return new WaitForSeconds(DelayValue);
        
        _isArleadyFiring = false;
    }

    public void ApplyDamage(int damage)
    {

        LifePoint -=  damage;
        if (LifePoint <= 0)
        {
            Destruction();
        }
    }

    protected virtual void Destruction()
    {
        Destroy(gameObject);
    }
}
