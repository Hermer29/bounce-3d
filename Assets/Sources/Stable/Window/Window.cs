using TMPro;
using UnityEngine;

namespace Bounce.Stable.Window
{
    public abstract class Window : MonoBehaviour
    {
        [SerializeField] private GameObject _screen;
        [SerializeField] private TMP_Text _resultText;

        private void Start()
        {
            if (_screen == null)
            {
                enabled = false;
                throw new MissingReferenceException(nameof(_screen));
            }
            if (_resultText == null)
            {
                enabled = false;
                throw new MissingReferenceException(nameof(_resultText));
            }
        }

        public void Show()
        {
            _screen.SetActive(true);
            _resultText.text = GetResultText();
        }

        public void Hide()
        {
            _screen.SetActive(false);
            _resultText.text = string.Empty;
        }

        protected abstract string GetResultText();
    }
}