using System;
using System.Collections.Generic;

namespace Command_Pattern
{
    class Program
    {
        public static void Main()
        {
            Ireceiver Receiver1 = new Receiver();
            Ireceiver Receiver2 = new Receiver2();
            Ireceiver Receiver3 = new Receiver3();
            int EstimatedDuration = 0;
            List<ICommand> Commands = new List<ICommand>();

            // Pass reference to the Receiver instance to each command
            ICommand Operation1 = new Command(Receiver1);
            ICommand Operation2 = new Command(Receiver2);
            ICommand Operation3 = new Command(Receiver3);
            ICommand Operation4 = new Command(Receiver1);
            ICommand Operation5 = new Command(Receiver1);

            Commands.Add(Operation1);
            Commands.Add(Operation2);
            Commands.Add(Operation3);
            Commands.Add(Operation4);
            Commands.Add(Operation5);

            // Pass reference to instances of the Command objects to the Invoker
            Invoker @Invoker = new Invoker(Commands);

            // The Invoker will invoke Execute() on the command object.
            foreach (Command command in Commands)
            {
                EstimatedDuration += @Invoker.EstimatedDurationLeft(command);
                Console.WriteLine(EstimatedDuration);
            }            
            
        }
    }
}
