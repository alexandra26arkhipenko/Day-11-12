using System;
using System.Threading;

namespace Timer
{
    public class Timer
    {
        /// <summary>
        /// The event occurs after the end of time
        /// </summary>
        public EventHandler<TimerEndEventArg> TimerEnd = delegate { };

        /// <summary>
        /// Notifies subscrube
        /// </summary>
        /// <param name="time">milliseconds</param>
        public void TimerUse(int time)
        {
            if (time < 0)
            {
                throw new ArgumentException(nameof(time),"Time must be greater than 0");
            }
            Thread.Sleep(time);
            OnTimerEnd(new TimerEndEventArg(DateTime.Now,time, "boom"));
        }

        public void OnTimerEnd(TimerEndEventArg e)
        {
            TimerEnd?.Invoke(this, e);
        }
    }
}
