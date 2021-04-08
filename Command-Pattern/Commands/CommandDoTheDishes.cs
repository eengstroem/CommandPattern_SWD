using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class CommandDoTheDishes : ICommand
    {
        private readonly IReceiver _receiver;
        public CommandDoTheDishes(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public int Duration()
        {
            return 3000;
        }

        public void Execute()
        {
            _receiver.DoTheDishes();
        }
    }
}
