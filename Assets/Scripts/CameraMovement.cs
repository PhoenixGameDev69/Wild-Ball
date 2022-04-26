using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _playerTransform.position;
        transform.LookAt(_playerTransform);
    }

    private void LateUpdate()
    {
        transform.position = _playerTransform.position + _offset;
    }
}
