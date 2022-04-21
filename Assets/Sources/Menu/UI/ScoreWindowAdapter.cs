using Bounce.Data;
using Bounce.Stable.Window;
using UnityEngine;
using UnityEngine.UI;

namespace Bounce.Menu.UI
{
    [RequireComponent(typeof(ScoreWindow), typeof(WindowController))]
    public class ScoreWindowAdapter : MonoBehaviour
    {
        [SerializeField] private Button _score;

        private WindowController _controller;
        private ScoreWindow _view;
        private IntegerPlayerPrefs _integer;

        private void Start()
        {
            _controller = GetComponent<WindowController>();
            _view = GetComponent<ScoreWindow>();
            _integer = new IntegerPlayerPrefs();
            _view.Construct(_integer);
            _score.onClick.AddListener(WindowOpening);
            _controller.EscapeClicked += WindowClosing;
        }

        private void WindowOpening()
        {
            _view.Show();
            _controller.Enable();
        }

        private void WindowClosing()
        {
            _view.Hide();
            _controller.Disable();
        }
    }
}
