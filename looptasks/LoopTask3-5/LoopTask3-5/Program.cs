using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;
            string evenStr = string.Empty; //2+4+6+8+10 =
            string oddStr = string.Empty; //1+3+5+7+9 =
            Console.WriteLine("Ohjelma laskee parittomien ja parillisten lukujen summan, myös negatiivisesti");
            Console.Write("Syötä luku: ");
            number = int.Parse(Console.ReadLine());

            while (i != number)
            {
                if (number > 0)
                {
                    i++;
                }
                else
                {
                    i--;
                }

                if (i % 2 == 0)
                {
                    evenSum += i;
                    if (i != number)
                    evenStr = $"{evenStr}{i} + "; 
                    else
                    evenStr = $"{evenStr}{i}";
                }
                else
                {
                    oddSum += i;
                    if (i != number - 1)
                    oddStr = $"{oddStr}{i} + ";
                    else
                    oddStr = $"{oddStr}{i}";
                }
            }
            Console.WriteLine($"{oddStr} = {oddSum}");
            Console.WriteLine($"{evenStr} = {evenSum}");
            
        }
    }
}
