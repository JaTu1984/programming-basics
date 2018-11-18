using System;



namespace Taulukkoharjoitus3._3

{

    class Program

    {

        static void Main(string[] args)

        {

            int[] arrT_1 = RndArray(10);

            int[] arrT_2 = RndArray(10);

            PrintData(arrT_1, "arrT_1:");

            PrintData(arrT_2, "arrT_2:");

        }



        /// <summary>

        /// Fill array with random numbers

        /// Set array lenght

        /// Return filled array

        /// </summary>

        /// <param name="length"></param>

        /// <returns>integer array</returns>

        static int[] RndArray(int length)

        {

            Random rnd = new Random();

            int[] arrT = new int[length];



            for (int i = 0; i < length; i++)

            {

                arrT[i] = rnd.Next(20);

            }

            return arrT;

        }



        /// <summary>

        /// Tulostaa taulukon tiedot näytölle.

        /// arrX = taulukko

        /// label = taulukon otsikko

        /// </summary>

        /// <param name="arrX"></param>

        /// <param name="label"></param>

        static void PrintData(int[] arrX, string label)

        {

            Console.Write($"{label} ");

            for (int i = 0; i < arrX.Length; i++)

            {

                Console.Write($"{arrX[i]:d2} ");

            }

            Console.WriteLine();

        }



    }

}