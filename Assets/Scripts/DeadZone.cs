using UnityEngine;
using UnityEngine.Events;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private float _lavaSpeed;
    [SerializeField] private GameObject _deadParticle;
    [SerializeField] private UnityEvent _onPlayerEnterTrigger;
    [SerializeField] private Material _lavaMaterial;

    private void Update()
    {
        _lavaMaterial.mainTextureOffset = new Vector2(_lavaMaterial.mainTextureOffset.x, _lavaMaterial.mainTextureOffset.y - Time.deltaTime * _lavaSpeed);

        if (_lavaMaterial.mainTextureOffset.y <= -10) _lavaMaterial.mainTextureOffset = Vector2.zero;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var deadObject = Instantiate(_deadParticle, other.transform.position, Quaternion.identity);
            Invoke(nameof(StartUnityEvent), 2.0f);
            other.gameObject.SetActive(false);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

    private void StartUnityEvent()
    {
        _onPlayerEnterTrigger?.Invoke();
    }
}
