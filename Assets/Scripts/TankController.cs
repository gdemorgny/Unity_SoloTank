using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : ActorController
{
    [SerializeField] private float _forwardSpeed = 0.2f;
    [SerializeField] private float _backwardSpeed = 0.2f;

    [SerializeField] private float _angleSpeed = 20f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0f, 0f, _forwardSpeed * Time.deltaTime);

        } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -_backwardSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, _angleSpeed * Time.deltaTime,0f);

        } else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, -_angleSpeed * Time.deltaTime,0f);

        }

    }
}
