﻿using System;

using System.Text.RegularExpressions;



namespace Palindrome

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Let's test for palindromes!\n");



            Console.WriteLine("Please enter a word.");

            // User Input

            string input = Console.ReadLine();



            // Check to see if input is correct

            // If not, clear console.

            Console.WriteLine("Is this your word? (y/n)");

            Console.Write("{0}: ", input);

            string yes_no = Console.ReadLine();

            if (yes_no == "y" || yes_no == "yes")

            {

                Console.WriteLine("Calculating Palindromism... \n");

                Palindrome.Tester(input);

            }

            else

            {

                Console.WriteLine("Trying again... \n");

                Main(args); // Restart The Program

            }



            Console.ReadLine();

        }



    }



    class Palindrome

    {

        /// <summary>

        /// Gets an input from user and checks to see if it is a palindrome.

        /// </summary>

        public static void Tester(string input)

        {

            string pattern = "\\W";



            string data = Regex.Replace(input.ToLower(), pattern, String.Empty);



            if (data == StringHelper.ReverseString(data))

            {

                // Console.Write(input); Console.Write(" is a Palindrome.");

                Console.WriteLine("{0} is a Palindrome.", input);

            }

            else

            {

                // Console.Write(input); Console.Write(" isn't a Palindrome.");

                Console.WriteLine("{0} isn't a Palindrome.", input);

            }



        }



    }



    static class StringHelper

    {

        /// <summary>

        /// Receives string and returns the string with its letters reversed.

        /// </summary>

        public static string ReverseString(string s)

        {

            char[] arr = s.ToCharArray();

            Array.Reverse(arr);

            return new string(arr);

        }



    }



}