﻿using System;

namespace Exercise09_Average
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to calculate and display the average of four numbers entered by the user.
        /// </summary>
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the four number: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            int result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("the average of {0} , {1} , {2} , {3} is: {4} ",
            num1, num2, num3, num4, result);
        }
    }
}
