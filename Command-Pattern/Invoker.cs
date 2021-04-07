using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{

    public enum ECommandGroup
    {

    }

    public class Invoker
    {

        private readonly ICommand _makeDinnerCommand;
        private readonly ICommand _eatDinnerCommand;
        private readonly ICommand _doTheDishesCommand;

        public Invoker(ICommand MakeDinnerCommand, ICommand EatDinnerCommand, ICommand DoTheDishesCommand)
        {
            _makeDinnerCommand = MakeDinnerCommand;
            _eatDinnerCommand = EatDinnerCommand;
            _doTheDishesCommand = DoTheDishesCommand;
        }

        /**
         * <summary>Executes the MakeDinner command</summary>
        * <returns>Estimated time required to make dinner in ms</returns>
        */
        public int MakeDinner()
        {
            _makeDinnerCommand.Execute();
            return _makeDinnerCommand.Duration();
        }

        /**
         * <summary>Executes the EatDinner command</summary>
        * <returns>Estimated time required to eat dinner in milliseconds</returns>
        */
        public int EatDinner()
        {
            _eatDinnerCommand.Execute();
            return _eatDinnerCommand.Duration();
        }

        /**
         * <summary>Executes the DoTheDishes command</summary>
        * <returns>Estimated time required to do the dishes in milliseconds</returns>
        */
        public int DoTheDishes()
        {
            _doTheDishesCommand.Execute();
            return _doTheDishesCommand.Duration();
        }

        /**
        * <returns>Returns the total estimated time in order to have dinner in milliseconds</returns>
        */
        public int GetTotalEstimatedDuration()
        {
            return _eatDinnerCommand.Duration() + _makeDinnerCommand.Duration() + _doTheDishesCommand.Duration();
        }

    }
}
