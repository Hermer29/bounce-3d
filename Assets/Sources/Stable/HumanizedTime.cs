using System;

namespace Bounce.Stable
{
    public class HumanizedTime
    {
        private TimeSpan _time;

        public HumanizedTime(TimeSpan time)
        {
            _time = time;
        }

        public HumanizedTime(int seconds) : this(TimeSpan.FromSeconds(seconds))
        {

        }

        public string Value
        {
            get => HumanizeTime(_time);
        }

        public override string ToString()
        {
            return Value;
        }

        private string HumanizeTime(TimeSpan timeSpan)
        {
            var seconds = (int)timeSpan.TotalSeconds;
            var minutes = seconds / 60;
            seconds %= 60;
            return $"{HumanizeNumber(minutes)}:{HumanizeNumber(seconds)}";
        }

        private string HumanizeNumber(int time)
        {
            return time / 10 >= 1 ? time.ToString() : $"0{time}";
        }
    }
}
