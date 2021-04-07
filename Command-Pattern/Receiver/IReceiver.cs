using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{
    public interface IReceiver
    {
        void EatDinner();
        void MakeDinner();
        void DoTheDishes();
    }
}
