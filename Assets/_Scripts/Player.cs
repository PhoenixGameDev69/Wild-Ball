using UnityEngine;

namespace WildBall
{
    [RequireComponent(typeof(Rigidbody))]
    public class Player : MonoBehaviour
    {
        [SerializeField][Range(0.0f, 20.0f)] private float _speed;
        [SerializeField] private LayerMask _interactionLayer;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        public void Move(Vector3 direction)
        {
            _rigidbody.AddForce(direction * _speed, ForceMode.Force);
        }

        public void TryUse()
        {
            var interactObj = Physics.OverlapSphere(transform.position, transform.localScale.x / 2, _interactionLayer);
            foreach (var obj in interactObj)
            {
                obj.GetComponent<InteractableComponent>().Interact();
            }
        }
    } 
}
