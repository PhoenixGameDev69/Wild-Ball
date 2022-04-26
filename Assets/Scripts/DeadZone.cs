using UnityEngine;
using UnityEngine.Events;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private GameObject _deadParticle;
    [SerializeField] private UnityEvent _onPlayerEnterTrigger;

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
