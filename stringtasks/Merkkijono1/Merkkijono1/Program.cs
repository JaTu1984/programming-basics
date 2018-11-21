using System;



namespace StringExample

{

    class Program

    {

        static void Main(string[] args)

        {
            int len = 0;

            Console.WriteLine("Ánna lause tai merkkijono: ");
            string userInput = Console.ReadLine();

            len = userInput.Length;

            Console.WriteLine($"Merkkijonossa {userInput} on merkkejä {len} kappaletta");

        }





















        static int CountLetter(string str)

        {

            int letterCounter = 0;

            for (int i = 0; i < str.Length; i++)

            {

                if (str[i] == 'L')

                    letterCounter++;

            }

            return letterCounter;

        }

    }

}
