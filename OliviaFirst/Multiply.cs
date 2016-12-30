using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliviaFirst
{
    class Multiply
    {
        static void Main()
        {
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Your answer is");
            Console.WriteLine(firstNumber*secondNumber);


            // Keep the console window open in debug mode.
             Console.ReadKey();
        }
    }
}
