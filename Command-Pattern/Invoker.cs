using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Invoker
    {
        private List<ICommand> _Commands;

        public Invoker(List<ICommand> Commands)
        {
            _Commands = Commands;
        }

        public int EstimatedDurationLeft(ICommand Command)
        {
            return _Commands[_Commands.IndexOf(Command)].Execute();
        }
    }
}
