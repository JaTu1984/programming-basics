using System;



namespace StringExample

{

    class Program

    {

        static void Main(string[] args)

        {

            string s = "Hello World!";

            string tmpS = MyReplace(s);

            tmpS = tmpS.Insert(s.Length - 1, "x");

            int cntrL = CountLetter(s.ToUpper());



            Console.WriteLine($"{s} {tmpS}");

            Console.WriteLine($"Merkkijonossa {s} on L kirjaimia {cntrL} kappaletta");

        }



        static string MyReplace(string str)

        {

            return str.Replace("e", "@");

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