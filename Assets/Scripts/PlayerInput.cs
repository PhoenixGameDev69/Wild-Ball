using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Player))]
    public class PlayerInput : MonoBehaviour
    {
        private Player _player;
        private Vector3 _direction;

        private void Awake()
        {
            _player = GetComponent<Player>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVars.HorizontalAxis);
            float vertical = Input.GetAxis(GlobalStringVars.VerticalAxis);

            _direction = new Vector3(horizontal, 0.0f, vertical).normalized;

            if (Input.GetKeyDown(KeyCode.E))
            {
                _player.TryUse();
            }
        }

        private void FixedUpdate()
        {
            _player.Move(_direction);
        }
    }
}
