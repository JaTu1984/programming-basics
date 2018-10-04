using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maatalousnäyttelyn lipunhinta: ");
            Console.WriteLine("Asiakasryhmät: Normaali, Alle 7v, 65v tai yli, 7-15v, Mtk jäsen, Varusmies, Opiskelija, Mtk+opiskelija");

            Console.Write("Anna asiakasryhmä: ");

            string userInput = Console.ReadLine();

            if (userInput == "Normaali")

                Console.WriteLine("Lipun hinta 16e");

            else

            if (userInput == "Alle 7v")

                Console.WriteLine("Lipun hinta ilmainen");

            else

            if (userInput == "65v tai yli")

                Console.WriteLine("Lipun hinta -50% 8e");

            else

            if (userInput == "7-15v")

                Console.WriteLine("Lipun hinta -50% 8e");

            else

            if (userInput == "Mtk jäsen")

                Console.WriteLine("Lipun hinta -15% 13,6e");

            else

            if (userInput == "Varusmies")

                Console.WriteLine("Lipun hinta -50% 8e");

            else

            if (userInput == "Opiskelija")

                Console.WriteLine("Lipun hinta -45% 8,8e");

            else

            if (userInput == "Mtk+opiskelija")

                Console.WriteLine("Lipun hinta -60% 6,4e");


        }
    }
}
