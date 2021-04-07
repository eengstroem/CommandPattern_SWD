using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public interface IDisplay
    {
        void InitNewLoadingBar(int TotalTime, int barLength);
        void DisplayTimeRemaining(int ms);
        void PrintStatus(string message);
    }
}
