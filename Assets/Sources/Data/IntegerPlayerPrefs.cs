using UnityEngine;

namespace Bounce.Data
{
    public class IntegerPlayerPrefs : IInteger
    {
        private const string LastScoreKey = "score";

        public int Get()
        {
            return PlayerPrefs.GetInt(LastScoreKey);
        }

        public void Set(int value)
        {
            PlayerPrefs.SetInt(LastScoreKey, value);
        }
    }
}
