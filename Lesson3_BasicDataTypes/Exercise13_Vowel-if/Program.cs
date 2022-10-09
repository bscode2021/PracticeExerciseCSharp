﻿using System;

namespace Exercise13_Vowel_if
{
    internal class Program
    {
        /// <summary>
        /// Create a program to ask the user for a symbol and answer if it is a 
        /// (lowercase)vowel, a digit, or any other symbol, using "if".
        /// </summary>
        static void Main(string[] args)
        {
            char symbol;

            Console.Write("Enter a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");
        }
    }
}
