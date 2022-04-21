using Bounce.Stable;
using Bounce.Stable.Window;
using System;
using System.Diagnostics;

namespace Bounce.Ride.UI
{
    internal class WinWindow : Window
    {
        private Stopwatch _rideTime;
        private bool _constructed;

        public void Construct(Stopwatch stopwatch)
        {
            if (_constructed)
                throw new InvalidOperationException();

            _constructed = true;
            _rideTime = stopwatch;
        }

        protected override string GetResultText()
        {
            if (_constructed == false)
                throw new InvalidOperationException();

            return $"Вы победили!\nВремя: {new HumanizedTime(_rideTime.Elapsed)}";
        }
    }
}
