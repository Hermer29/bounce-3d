using Bounce.Data;
using Bounce.Stable.Window;
using System.Diagnostics;
using UnityEngine;

namespace Bounce.Ride.UI
{
    public class WinWindowAdapter : MonoBehaviour
    {
        [SerializeField] private WinWindow _wonScreen;
        [SerializeField] private Stopwatch _gameTimer;
        [SerializeField] private WindowController _controller;

        private IntegerPlayerPrefs _integer;

        private void Start()
        {
            _gameTimer = new Stopwatch();
            _integer = new IntegerPlayerPrefs();
            _wonScreen.Construct(_gameTimer);
            _gameTimer.Start();
        }

        public void Open()
        {
            _wonScreen.Show();
            _controller.Enable();
        }

        public void StopAndSave()
        {
            _gameTimer.Stop();
            _integer.Set((int) _gameTimer.Elapsed.TotalSeconds);
        }
    }
}
