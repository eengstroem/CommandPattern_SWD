using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Command : ICommand
    {
        private Ireceiver _switchable;

        public Command(Ireceiver switchable)
        {
            _switchable = switchable;
        }

        public int Execute()
        {
            return _switchable.EstimatedDurationLeft();
        }
    }
}
