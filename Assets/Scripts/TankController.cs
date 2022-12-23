using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : ActorController
{
    [SerializeField] private float _forwardSpeed = 0.2f;
    [SerializeField] private float _backwardSpeed = 0.2f;

    [SerializeField] private float _angleSpeed = 20f;
    [SerializeField] private GameObject _cameraLocator;

    void Update()
    {
        Move();
        AimToMouse();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
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

    private void AimToMouse()
    {
        Ray rayToMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(rayToMouse.origin, rayToMouse.direction * 20f,Color.red);
        RaycastHit hit;
        if (Physics.Raycast(rayToMouse, out hit))
        {
            RotateHeadTo(new Vector3(hit.point.x, _head.transform.position.y, hit.point.z));
        }  
                
    }

    protected override void Destruction()
    {

        _cameraLocator.transform.SetParent(null);
        base.Destruction();
    }

}
