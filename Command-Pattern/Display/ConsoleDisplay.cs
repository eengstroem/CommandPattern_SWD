using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{


    public class ConsoleDisplay : IDisplay
    {

        public void DisplayTimeRemaining(int ms)
        {
            Console.WriteLine((ms / 1000) + " seconds left.");
        }

        public void PrintStatus(string message)
        {
            Console.WriteLine(message);
        }
    }
}
