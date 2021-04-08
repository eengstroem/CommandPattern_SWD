using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Pattern
{

    public class ConsoleDisplay : IDisplay
    { 

        private int _previousPos = 0;
        private int _totalTime = 0;
        private int _barLength = 0;
        private double _ratio = 0;
        private char previousLoadChar;

        /**
         * <summary>Initializes variables for a new loading bar</summary>
         * <param name="barLength">The amount of hashtags for the whole loading bar</param>
         * <param name="TotalTime">The total estimated time to complete the load</param>
         */
        public void InitNewLoadingBar(int TotalTime, int barLength)
        {
            Console.WriteLine("Loading...");
            _totalTime = TotalTime/1000;
            _barLength = barLength;
            _ratio = (double)_barLength / _totalTime;
            _previousPos = 0;
            Console.SetCursorPosition(_barLength + 1, Console.CursorTop = 1);
            previousLoadChar = '|';
            Console.Write("|");
        }
        /**
         * <summary>Draws a specific amount of the loading bar</summary>
         * <param name="ms">The estimated time for one component being loaded</param>
         */
        public void DisplayTimeRemaining(int ms)
        {
            Console.SetCursorPosition(_previousPos, Console.CursorTop = 1);
            for (int i = 0; i < _ratio * (ms / 1000); i++)
            {
                Console.Write("#");
            }
            _previousPos = (int)(_ratio * (ms / 1000)) + _previousPos;

            switch(previousLoadChar)
            {
                case '|':
                    Console.SetCursorPosition(_barLength + 1, Console.CursorTop = 1);
                    Console.Write("/");
                    previousLoadChar = '/';
                    break;
                case '/':
                    Console.SetCursorPosition(_barLength + 1, Console.CursorTop = 1);
                    Console.Write("-");
                    previousLoadChar = '-';
                    break;
                case '-':
                    Console.SetCursorPosition(_barLength + 1, Console.CursorTop = 1);
                    Console.Write("|");
                    previousLoadChar = '|';
                    break;
            }
        }
        /**
         * <summary>Prints status under the loading bar</summary>
         * <param name="message">The message to be sent.</param>
         */
        public void PrintStatus(string message)
        {
            Console.CursorTop = 2;
            ClearCurrentConsoleLine();
            Console.WriteLine(message);
        }
        /**
         * <summary>Function to clear a line in the console, to allow PrintStatus to overwrite any message prior</summary>
         */
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
