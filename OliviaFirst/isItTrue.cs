using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliviaFirst
{
    class guessMyAge
    {
        static void Main() {

            
            Console.WriteLine("guess my age");
            int myAge = int.Parse(Console.ReadLine());

            Boolean isMyAgeRight = (myAge == 9);
            Console.WriteLine(isMyAgeRight);

            
            Console.ReadKey();
        }
    }
}
