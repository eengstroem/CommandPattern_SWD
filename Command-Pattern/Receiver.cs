using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public class Receiver : Ireceiver
    {
        public int EstimatedDurationLeft()
        {
            return 5;
        }
    }

    public class Receiver2 : Ireceiver
    {
        public int EstimatedDurationLeft()
        {
            return 10;
        }
    }

    public class Receiver3 : Ireceiver
    {
        public int EstimatedDurationLeft()
        {
            return 15;
        }
    }
}
