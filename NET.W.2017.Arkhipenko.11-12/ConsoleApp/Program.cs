using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer.Timer timer = new Timer.Timer();
           

            User user1 = new User();
            User user2 = new User();

            timer.TimerEnd += user1.Reaction;
            timer.TimerEnd += user2.Reaction;

            timer.TimerUse(1000);
       
            timer.TimerEnd -= user2.Reaction;
            timer.TimerUse(1000);
            Console.ReadKey();
        }
    }
}
