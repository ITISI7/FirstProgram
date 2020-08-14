using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableOperatorsExpressions
{
    class Program
    {
        static void Main()
        {
            string greeting = "Hello user! the game start condition is: ";
            bool gameStarted = false;
            string displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            gameStarted = true;
            displayGameState = greeting + gameStarted;
            Console.WriteLine(displayGameState);
            Console.ReadKey();
        }
    }
}
