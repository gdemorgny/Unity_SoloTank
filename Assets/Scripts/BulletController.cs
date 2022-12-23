using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _lifeDuration = 2f;
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up*_speed;
        Destroy(gameObject, _lifeDuration);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInParent<ActorController>() != null)
        {
            collision.gameObject.GetComponentInParent<ActorController>().ApplyDamage(_damage);
        }
        Destroy(gameObject);
    }
}
