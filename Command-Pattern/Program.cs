using System;
using System.Collections.Generic;
//hella ebin
namespace Command_Pattern
{
    class Program
    {
        public static void Main()
        {
            ConsoleDisplay disp = new();

            Receiver Receiver = new(disp);

            Invoker inv = new(
                new CommandMakeDinner(Receiver),
                new CommandEatDinner(Receiver),
                new CommandDoTheDishes(Receiver));

            DinnerControl ctrl = new(disp, inv);

            ctrl.HaveDinner();

        }
    }
}