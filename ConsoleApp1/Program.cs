﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numInput = int.Parse(Console.ReadLine());
            int finalSum = 0;

            while (numInput != 0)
            {
                int lastDigit = numInput % 10;
                finalSum += lastDigit;

                numInput /= 10;


            }

            Console.WriteLine(finalSum);


        }
    }
}
