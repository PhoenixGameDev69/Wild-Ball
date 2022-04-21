using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private string[] _triggerNames;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnAnimationChange()
    {
        var animationNum = Random.Range(0, _triggerNames.Length);
        _animator.SetTrigger(_triggerNames[animationNum]);
    }
}
