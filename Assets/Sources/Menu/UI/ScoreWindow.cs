using Bounce.Data;
using Bounce.Stable;
using Bounce.Stable.Window;

namespace Bounce.Menu.UI
{
    public class ScoreWindow : Window
    {
        private IntegerPlayerPrefs _integer;

        public void Construct(IntegerPlayerPrefs integer)
        {
            _integer = integer;
        }

        protected override string GetResultText()
        {
            return $"Время: {new HumanizedTime(_integer.Get())}";
        }
    }
}
