using UnityEngine;

namespace Bounce.Ride.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Update()
        {
            var forwardBackward = -Input.GetAxis("Vertical");
            var leftRight = Input.GetAxis("Horizontal");
            _player.Move(new Vector3(forwardBackward, 0, leftRight));
        }
    }
}
