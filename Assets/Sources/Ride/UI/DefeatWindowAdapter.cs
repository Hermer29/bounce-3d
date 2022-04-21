using Bounce.Stable;
using Bounce.Stable.Window;
using UnityEngine;

namespace Bounce.Ride.UI
{
    public class DefeatWindowAdapter : MonoBehaviour
    {

        [SerializeField] private DefeatWindow _view;
        [SerializeField] private WindowController _controller;

        private SceneTransitions _scenes;

        private void Start()
        {
            _scenes = new SceneTransitions();
            _controller.EscapeClicked += _scenes.ReturnToMenu;
        }

        public void Open()
        {
            _view.Show();
            _controller.Enable();
        }
    }
}
