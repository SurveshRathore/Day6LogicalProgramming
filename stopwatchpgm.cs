using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSummation
{
    public class stopwatchpgm
    {
        public void calcTime()
        {
            int choice;
            TimeOnly startTime;
            TimeOnly EndTime;
            TimeSpan elapsedTime;
            Console.WriteLine("Enter 1 to start the stopwatch. ");
            

            choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                startTime = TimeOnly.FromDateTime(DateTime.Now);
            }

            Console.WriteLine("Enter 2 to stop the stopwatch. ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 2)
            {
                EndTime = TimeOnly.FromDateTime(DateTime.Now);
            }

            elapsedTime = EndTime - startTime;

            Console.WriteLine("The elapsed time is: " + elapsedTime + " seconds");
        }
    }
}


///////////program.cs
stopwatchpgm stopwatchpgm = new stopwatchpgm();
stopwatchpgm.calcTime();
