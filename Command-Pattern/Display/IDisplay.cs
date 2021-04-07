using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public interface IDisplay
    {
        void DisplayTimeRemaining(int ms);
        void PrintStatus(string message);
    }
}
