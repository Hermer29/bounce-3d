using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Bounce.Stable;

namespace Bounce.Menu.UI
{
    public class PlayButtonListener : MonoBehaviour
    {
        [SerializeField] private Button _play;
        private SceneTransitions _scenes;

        private void Start()
        {
            _scenes = new SceneTransitions();
            _play.onClick.AddListener(new UnityAction(_scenes.GoToGame));
        }

        private void OnDisable()
        {
            _play.onClick.RemoveAllListeners();
        }
    }
}
