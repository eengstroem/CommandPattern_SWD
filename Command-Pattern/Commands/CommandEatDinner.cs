using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class CommandEatDinner : ICommand
    {
        private readonly IReceiver _receiver;
        public CommandEatDinner(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public int Duration()
        {
            return 4000; //4
        }

        public void Execute()
        {
            _receiver.EatDinner();
        }
    }
}
