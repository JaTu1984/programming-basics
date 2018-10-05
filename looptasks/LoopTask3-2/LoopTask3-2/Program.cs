using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen");

            int number = 0;
            int i = 1;
            int sum = 0;

         //check that number is positive number
            do
            {
                Console.Write("Anna kokonaisluku: ");
                string userInput = Console.ReadLine();
                bool isNumber = int.TryParse(userInput,out number);
                
                
                if (number < 1 || !isNumber)
                {
                    Console.WriteLine("Virheellinen syöte");
                }
                

            } while (number < 1);
            
            while (i <= number)
            {
                sum = sum + i; //fact=*i
                i = i + 1;      //i++;

            }
            
            Console.WriteLine($"Kokonaisluvun {number} summa = {sum}");
        }
    }
}
