using UnityEngine.SceneManagement;

namespace Bounce.Stable
{
    public class SceneTransitions
    {
        public void GoToGame()
        {
            SceneManager.LoadScene(Scene.Game);
        }

        public void ReturnToMenu()
        {
            SceneManager.LoadScene(Scene.Menu);
        }
    }
}