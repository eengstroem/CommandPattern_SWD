using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class CommandMakeDinner : ICommand
    {
        private readonly IReceiver _receiver;
        public CommandMakeDinner(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public int Duration()
        {
            return 8000; // 8
        }

        public void Execute()
        {
            _receiver.MakeDinner();
        }
    }
}
