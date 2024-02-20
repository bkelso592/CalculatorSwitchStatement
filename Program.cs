using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char operation;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the operator (+, -, /, *): ");
            operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (operation == '-')
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (operation == '*')
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine($"{num1} / {num2} = {(double)num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
            }
            else
            {
                Console.WriteLine("Error: Unsupported operator.");
            }
        }
    }
}
