using UnityEngine;
using UnityEngine.Events;

namespace Bounce.Ride.GameLevel
{
    public class FinishTriggerListener : MonoBehaviour
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private Trigger _finishTrigger;
        [SerializeField] private PlayerFinished _onPlayerFinished;

        private void Start()
        {
            _finishTrigger.OnTriggerEntered.AddListener(new UnityAction<GameObject>(OnTriggerEntered));
        }

        private void OnTriggerEntered(GameObject gameObject)
        {
            if(_player == gameObject)
            {
                _onPlayerFinished?.Invoke();
            }
        }

        private void OnDisable()
        {
            _finishTrigger.OnTriggerEntered.RemoveAllListeners();
        }
    }

    [System.Serializable]
    public class PlayerFinished : UnityEvent
    {

    }
}
