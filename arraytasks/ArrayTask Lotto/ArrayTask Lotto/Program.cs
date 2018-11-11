using System;



namespace Lotto

{

    class Program

    {



        static void Main(string[] args)

        {

            int[] lottery = new int[40];

            Intro();

            RndLotteryNumbers(ref lottery, 7, 1);

            RndLotteryNumbers(ref lottery, 1, 2);

            PrintLottery(lottery);

        }



        static void Intro()

        {

            Console.WriteLine("Arvotaan lotto-ohjelman mukainen lottorivi.");

            Console.Write("Paina jotain painiketta - Arvonta alkaa!");

            Console.ReadKey();

        }



        /// <summary>

        /// amount is how many numbers will random

        /// value is what will set to array

        /// 1=real lottery number

        /// 2=extra number

        /// </summary>

        /// <param name="amount"></param>

        /// <param name="value"></param>

        /// <returns></returns>

        static void RndLotteryNumbers(ref int[] arrLottery, int amount, int value)

        {

            Random rnd = new Random();

            for (int i = 0; i < amount; i++)

            {

                int rndNumber = rnd.Next(arrLottery.Length);

                if (arrLottery[rndNumber] == 0)

                    arrLottery[rndNumber] = value;

                else

                    i--;

            }

        }



        static void PrintLottery(int[] arrLottery)

        {

            Random rnd = new Random();

            Console.Write("\nLoton oikea rivi: ");

            for (int i = 0; i < arrLottery.Length; i++)

            {

                if (arrLottery[i] == 1)

                    Console.Write($"{i + 1} ");

            }



            Console.Write("\nLisänumero: ");

            for (int i = 0; i < arrLottery.Length; i++)

            {

                if (arrLottery[i] == 2)

                    Console.Write($"{i + 1} ");

            }



            Console.WriteLine($"\nPlussausnumero: {rnd.Next(40) + 1}");

        }

    }

}
