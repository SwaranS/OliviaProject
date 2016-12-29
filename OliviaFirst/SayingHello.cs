using System;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            //String aboutOlivia = "Olivia goes to St Fiachrans";

            int oliviaAge = 9;
            int preetAge = 3;
            int coleenAge = 3;
            Console.WriteLine("Current Ages");
            Console.WriteLine(oliviaAge+preetAge+coleenAge);


           
            Console.WriteLine("Multiply by 5");
            int oliviaNewAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Answer");
            Console.WriteLine(oliviaNewAge * 5);

           

        }
    }
}
