using System;
using System.Dynamic;

namespace Timer
{
    public class TimerEndEventArg
    {
        public int Time { get;  }
        public string Message { get;  }
        public DateTime TimerEndTime { get; }

        public TimerEndEventArg(DateTime timerEndTime, int time, string message)
        {
            TimerEndTime = timerEndTime;
            Time = time;
            Message = message;
        }
    }
}
