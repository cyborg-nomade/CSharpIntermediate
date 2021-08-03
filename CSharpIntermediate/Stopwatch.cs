using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime _currentStartTime;
        private TimeSpan _currentTimeSpan;
        public void Start()
        {
            this._currentStartTime = DateTime.Now;
            Console.WriteLine("The stopwatch has been started");
        }

        public void Stop()
        {
            this._currentTimeSpan = DateTime.Now - this._currentStartTime;
            Console.WriteLine("Stopwatch measure: " + _currentTimeSpan);
            Reset();
        }

        public void Reset()
        {
            this._currentStartTime = DateTime.MinValue;
            this._currentTimeSpan = TimeSpan.MinValue;
        }
    }
}