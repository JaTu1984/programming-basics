using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Ohjelma laskee N! kertoman arvon");
            int number = 0;
            int i = 1;
            int fact = 1;

            //check that number is positive number
            do
            {
                Console.Write("Anna kokonaisluku: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);
                //number = int.Parse(Console.ReadLine());
                //while (number <= 0);

                if (number <= 0)
                {
                    Console.WriteLine("Virheellinen syöte");
                }
                //else
                //{
                //   break;
                //}
                //}while (true)

                //Console.Write("Anna kokonaisluku: ");
                //userInput = Console.ReadLine();
                //number = int.Parse(userInput);

            } while (number <= 0);
             //Calculate factorial 1 * 2 * 3 * ... * n
             while (i <= number)
            {
                fact = fact * i; //fact=*i
                i = i + 1;      //i++;

            }
            //for (i = 1; i <= number; i++)
            //{
            //  fact *= i;
            //}
            Console.WriteLine($"Kokonaisluvun {number} ! = {fact}");










        }
    }
}
