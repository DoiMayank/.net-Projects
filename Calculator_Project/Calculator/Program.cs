using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            string answer;
            Console.WriteLine("Hello, welcome to the calculator code");

            Console.WriteLine("Please enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your SECOND number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation you like to do ?");
            Console.WriteLine("Pls enter a for addition , s for subtraction, m for multiplication or d for divide");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else
            {
                result = num1 / num2;
            };

            Console.WriteLine("The result is " + result);

            Console.ReadLine();
        }

    }
}
