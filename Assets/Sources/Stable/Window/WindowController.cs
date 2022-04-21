using System;
using UnityEngine;

namespace Bounce.Stable.Window
{
    public class WindowController : MonoBehaviour
    { 
        private bool _enabled;

        public event Action EscapeClicked;

        private void Update()
        {
            if (_enabled == false)
                return;

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                EscapeClicked?.Invoke();
            }
        }

        public void Enable()
        {
            _enabled = true;
        }

        public void Disable()
        {
            _enabled = false;
        }
    }
}
