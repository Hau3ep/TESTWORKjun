using UnityEngine;

public class CubeManagement: MonoBehaviour
{
    [Header("Vector to Move")]
    [Range(0f,1f)]
    [SerializeField] private float _x, _y, _z;

    [Header("Basic Parameters")]
    [SerializeField] private float _speed = 1f, _distance = 1f;
    private Transform _cubeTransform;
    private Vector3 _startPositionCube;
    private Vector3 _vectorToMove;
    private float _distantionToEnd;
    [SerializeField] private DisplayingValues _dv;

    private void Start()
    {
        _dv = Camera.main.gameObject.GetComponent<DisplayingValues>();
        _cubeTransform = transform;
        _startPositionCube = _cubeTransform.position;
        _vectorToMove = new Vector3(_x, _y, _z);
    }
    private void Update()
    {
        _distantionToEnd = Vector3.Distance(transform.position, _startPositionCube + _vectorToMove * _distance);
        _speed = _dv._speed;
        _distance = _dv._distance;
        if (_vectorToMove != Vector3.zero)
        {
            if (_distantionToEnd <= 1f && _distantionToEnd != 0f)
            {
                Destroy(transform.gameObject,1f);
            }
            _cubeTransform.position = Vector3.Lerp(_cubeTransform.position, _startPositionCube + _vectorToMove * _distance, _speed * 0.1f * Time.deltaTime);
        }
        else
        {
            Debug.LogWarning("Vector To move = Zero");
        }
    }
}
