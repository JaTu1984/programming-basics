using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee 3 kokonaislukua nousevaan järjestykseen");
            Console.WriteLine("Anna ohjelmalle 3 kokonaislukua:");

            Console.Write("Syötä 1. luku: ");
            string userInput = Console.ReadLine();
            int x = int.Parse(userInput);
            Console.Write("Syötä 2. luku: ");
            userInput = Console.ReadLine();
            int y = int.Parse(userInput);
            Console.Write("Syötä 3. luku: ");
            userInput = Console.ReadLine();
            int z = int.Parse(userInput);

            if ((x > y) && (x > z) && (y > z))

                Console.WriteLine($"Syötit arvot {x} - {y} - {z}");

            else

            if ((y > x) && (y > z) && (x > z))

                Console.WriteLine($"Syötit arvot {y} - {x} - {z}");

            else

            if ((z > x) && (z > y) && (x > y))

                Console.WriteLine($"Syötit arvot {z} - {x} - {y}");
            else

            if ((z > x) && (z > y) && (y > x))

                Console.WriteLine($"Syötit arvot {z} - {y} - {x}");

            else

            if ((y > z) && (y > x) && (z > x))

                Console.WriteLine($"Syötit arvot {y} - {z} - {x}");

            else

            if ((x > y) && (x > z) && (z > y))

                Console.WriteLine($"Syötit arvot {x} - {z} - {y}");

            else

            if ((x == y) && (y == z) && (z == x))

                Console.WriteLine($"Syötit arvot {x} - {y} - {z}");

            else

            if ((x == y) && (z > x))

                Console.WriteLine($"Syötit arvot {z} - {x} - {y}");

            else

            if ((x > y) && (y == z))

                Console.WriteLine($"Syötit arvot {x} - {y} - {z}");

            else

            if ((x == z) && (y > x))

                Console.WriteLine($"Syötit arvot {y} - {x} - {z}");

            else

            if ((y == z) && (y > x))

                Console.WriteLine($"Syötit arvot {y} - {z} - {x}");

            else

            if ((x == y) && (x > z))

                Console.WriteLine($"Syötit arvot {x} - {y} - {z}");

            else

            if ((x == z) && (x > y))

                Console.WriteLine($"Syötit arvot {x} - {z} - {y}");


            
        }
    }
}
