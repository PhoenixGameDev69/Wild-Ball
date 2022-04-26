using UnityEngine;
using UnityEngine.Events;

public class EnterExitTriggerComponent : MonoBehaviour
{
    [SerializeField] private LayerMask _layers;

    [SerializeField] private UnityEvent _onEnter;
    [SerializeField] private UnityEvent _onExit;

    private void OnTriggerEnter(Collider other)
    {
        var goLayer = (_layers | 1 << other.gameObject.layer);

        if (_layers == goLayer)
        {
            _onEnter?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var goLayer = (_layers | 1 << other.gameObject.layer);

        if (_layers == goLayer)
        {
            _onExit?.Invoke();
        }
    }
}
