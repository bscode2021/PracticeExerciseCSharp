﻿using System;

namespace Exercise08_MultiplicationTable
{
    internal class Program
    {
        /// <summary>
        /// Write a C# program to ask the user for a number and display its multiplication table, like this:
        /// 
        /// 5 x 1 = 5
        /// 5 x 2 = 10
        /// 5 x 3 = 15
        /// ...
        /// 5 x 10 = 50
        /// </summary>
        static void Main(string[] args)
        {
            int x;
            int result;
            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            result = x * 0;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 0, result);
            result = x * 1;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 1, result);
            result = x * 2;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 2, result);
            result = x * 3;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 3, result);
            result = x * 4;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 4, result);
            result = x * 5;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 5, result);
            result = x * 6;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 6, result);
            result = x * 7;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 7, result);
            result = x * 8;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 8, result);
            result = x * 9;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 9, result);
            result = x * 10;
            Console.WriteLine("The result is: {0} x {1} = {2}", x, 10, result);
        }
    }
}
