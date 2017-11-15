using System;
using Timer;
namespace ConsoleApp
{
    public class User
    {

        public void Reaction(object sender, TimerEndEventArg e)
        {
            Console.WriteLine(e.Message);
        }
    }
}