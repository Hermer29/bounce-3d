using UnityEngine;
using UnityEngine.Events;

namespace Bounce.Ride.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody _playersBody;
        [SerializeField, Min(1)] private float _torqueForce;
        [Header("Высота смерти рисуется в gizmo")]
        [SerializeField] private float _deathHeight;
        [SerializeField] private OnPlayerDead _onDead;

        private bool _movementLocked;

        private bool IsOutOfBounds => _playersBody.transform.position.y <= _deathHeight;

        private void RestrictMovement()
        {
            _movementLocked = true;
        }

        public void Move(Vector3 direction)
        {
            if (_movementLocked)
                return;

            _playersBody.AddTorque(direction * _torqueForce);
        }

        public void Stop()
        {
            _playersBody.velocity = Vector3.zero;
            _playersBody.angularVelocity = Vector3.zero;
        }

        private void Update()
        {
            if (_movementLocked)
                return;

            if(IsOutOfBounds)
            {
                RestrictMovement();
                _onDead?.Invoke();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawCube(new Vector3(0, _deathHeight), new Vector3(100, 0.1f, 100));
        }
    }

    [System.Serializable]
    public class OnPlayerDead : UnityEvent
    {
    }
}
