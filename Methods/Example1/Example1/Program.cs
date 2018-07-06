using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        public static void Sum(int first, int second) //method needs to be static because we are calling it in a static Main method.
        {
            int result = first + second;
            Console.WriteLine($"Sum result: {result}");
        }

        public static void Substract(int first, int second)
        {
            int result = first - second;
            Console.WriteLine($"Substraction result: {result}");
        }

        public static void Multiplication(int first, int second)
        {
            int result = first * second;
            Console.WriteLine($"Multiplication result: {result}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstArgument = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondArgument = Convert.ToInt32(Console.ReadLine());

            Sum(firstArgument, secondArgument);
            Substract(firstArgument, secondArgument);
            Multiplication(firstArgument, secondArgument);

            Console.ReadKey();
        }
    }
}
