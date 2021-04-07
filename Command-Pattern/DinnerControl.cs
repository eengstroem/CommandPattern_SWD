using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    class DinnerControl
    {

        private readonly Invoker _invoker;
        private readonly IDisplay _disp;
        public DinnerControl(IDisplay Display, Invoker Invoker)
        {
            _disp = Display;
            _invoker = Invoker;
        }

        public void HaveDinner()
        {
            _disp.InitNewLoadingBar(_invoker.GetTotalEstimatedDuration(), 30); // 15 sec

            _disp.DisplayTimeRemaining(_invoker.MakeDinner()); // 15 sec - 8 sec = 7 sec

            _disp.DisplayTimeRemaining(_invoker.EatDinner());// 7 sec - 4 sec = 3 sec

            _disp.DisplayTimeRemaining(_invoker.DoTheDishes());// 3 sec - 3 sec = 0 sec

            _disp.PrintStatus("DONE");

        }

    }
}
