using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int firstAndSecond = firstNumber + secondNumber;
            int divided = firstAndSecond / thirdNumber;

            int result = divided * fourthNumber;

            Console.WriteLine($"{result}");


        }
    }
}
