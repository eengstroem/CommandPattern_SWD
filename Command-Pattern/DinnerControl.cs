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
            int EstimatedDuration = _invoker.GetTotalEstimatedDuration();

            _disp.DisplayTimeRemaining(EstimatedDuration);
            EstimatedDuration -= _invoker.MakeDinner();
            _disp.DisplayTimeRemaining(EstimatedDuration);
            EstimatedDuration -= _invoker.EatDinner();
            _disp.DisplayTimeRemaining(EstimatedDuration);
            EstimatedDuration -= _invoker.DoTheDishes();
            _disp.DisplayTimeRemaining(EstimatedDuration);
            _disp.PrintStatus("DONE");

        }

    }
}
