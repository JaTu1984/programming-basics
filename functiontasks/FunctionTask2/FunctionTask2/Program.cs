using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Funktio palauttaa arvonaan kahdesta annetusta luvusta pienemmän");

            int number1;
            int number2;
            int i = 0;

            do
                Console.WriteLine("Anna kokonaisluku: ");
            while (i == 2);
            i = i + 1;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)

                Console.WriteLine($"{number2} on pienempi kuin {number1}");

            if (number2 > number1)

                Console.WriteLine($"{number1} on pienempi kuin {number2}");

            if (number1 == number2)

                Console.WriteLine("Luvut ovat yhtä suuret");
        }
    }
}
