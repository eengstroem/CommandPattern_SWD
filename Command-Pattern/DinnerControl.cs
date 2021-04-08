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
            _disp.InitNewLoadingBar(_invoker.GetTotalEstimatedDuration(), 30);

            _disp.DisplayTimeRemaining(_invoker.MakeDinner());

            _disp.DisplayTimeRemaining(_invoker.EatDinner());

            _disp.DisplayTimeRemaining(_invoker.DoTheDishes());

            _disp.PrintStatus("DONE");

        }

    }
}
