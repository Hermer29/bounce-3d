using UnityEngine;

namespace Bounce.Ride.Player
{
    public class ThirdPersonCamera : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private Transform _player;
        private Vector3 _lastPlayerPosition;
        private bool _isFollowingPlayer = true;
        private bool _isSpectatingPlayer;

        private void Start()
        {
            _lastPlayerPosition = _player.transform.position;
        }

        public void ToggleMoving()
        {
            _isFollowingPlayer = !_isFollowingPlayer;
        }

        public void StopMovingAndLookAt(Transform point)
        {
            _isFollowingPlayer = false;
            _isSpectatingPlayer = true;
        }

        private void LateUpdate()
        {
            if (_isFollowingPlayer)
                FollowPlayer();

            if (_isSpectatingPlayer)
                SpectatePlayer();
        }

        private void FollowPlayer()
        {
            var playerDeltaPosition = _player.position - _lastPlayerPosition;
            _camera.transform.position += playerDeltaPosition;
            _lastPlayerPosition = _player.position;
        }

        private void SpectatePlayer()
        {
            Vector3 fromCameraToPlayer = _player.position - _camera.transform.position;
            var rotation = Quaternion.LookRotation(fromCameraToPlayer);
            _camera.transform.rotation = rotation;
        }
    }
}
