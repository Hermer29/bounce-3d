using UnityEngine;
using UnityEngine.Events;

namespace Bounce.Ride.GameLevel
{
    [RequireComponent(typeof(Collider))]
    public class Trigger : MonoBehaviour
    {
        public OnTriggerEnter OnTriggerEntered;

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEntered?.Invoke(other.gameObject);
        }
    }

    [System.Serializable]
    public class OnTriggerEnter : UnityEvent<GameObject>
    {

    }
}
