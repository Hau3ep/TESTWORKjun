using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Object _objectForSpawn;
    [SerializeField] private DisplayingValues _dv;

    public float _timeForSpawn = 1f;
    public float _speed = 1f;
    public float _distance = 1f;

    private GameObject _objectForOp;


    private void Start()
    {
        _dv = Camera.main.gameObject.GetComponent<DisplayingValues>();
    }
    private void Update()
    {
        _speed = _dv._speed;
        _distance = _dv._distance;
        if (_objectForSpawn != null)
        {
            if (_timeForSpawn <= 0f && _speed != 0f && _distance != 0f)
            {
                _timeForSpawn = _dv._time;
            }
            _timeForSpawn -= Time.fixedDeltaTime;

            if (_timeForSpawn <= 0f)
            {
                _objectForOp = (GameObject)Instantiate(_objectForSpawn);
                _objectForOp.transform.position = transform.position;
                _timeForSpawn = _dv._time;
            }
        }
        else
        {
            Debug.LogWarning("add a prefab for spawn");
        }
    }
}
