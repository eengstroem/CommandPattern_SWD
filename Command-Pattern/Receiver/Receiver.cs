using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Receiver : IReceiver
    {
        private IDisplay _display;
        public Receiver(IDisplay Display)
        {
            _display = Display;
        }

        public void DoTheDishes()
        {
            _display.PrintStatus("Doing dishes...");
            Thread.Sleep(3000);
        }

        public void EatDinner()
        {
            _display.PrintStatus("Eating...");
            Thread.Sleep(4000);
        }

        public void MakeDinner()
        {
            _display.PrintStatus("Making Dinner...");
            Thread.Sleep(8000);
        }
    }

}
