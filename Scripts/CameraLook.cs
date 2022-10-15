using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] private float _turnSpeed;
    [SerializeField] private Transform _trObject;
    [SerializeField] private float distanceY, distanceZ;
    private float firstY, firstZ;
    private Vector3 _cameraDist;

    private void Start()
    {
        firstY = distanceY;
        firstZ = distanceZ;
        //_cameraDist = new Vector3(_trObject.position.x, _trObject.position.y + distanceY, _trObject.position.z + distanceZ);
    }
    private void FixedUpdate()
    {
        if (_trObject == null)
        {
            _trObject = GameObject.FindGameObjectWithTag("TargetObject").transform;
        }
        else
        {
            if (distanceY != firstY)
            {
                _cameraDist = new Vector3(_trObject.position.x, _trObject.position.y + distanceY, _trObject.position.z + distanceZ);
                firstY = distanceY;
            }
            if (distanceZ != firstZ)
            {
                _cameraDist = new Vector3(_trObject.position.x, _trObject.position.y + distanceY, _trObject.position.z + distanceZ);
                firstZ = distanceZ;
            }
            _cameraDist = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * _turnSpeed, Vector3.up) * _cameraDist;
            //transform.position = _trObject.position + _cameraDist;
            transform.LookAt(_trObject.position);
        }
    }
}