using Estagio_Ribeirao_Preto_2024.Entities.Exceptions.Question2;
using Estagio_Ribeirao_Preto_2024.Entities.Question1;
using Estagio_Ribeirao_Preto_2024.Entities.Question5;
using Estagio_Ribeirao_Preto_2024.Services.Question2;
using Estagio_Ribeirao_Preto_2024.Services.Question5;
using System;

namespace Estagio_Ribeirao_Preto_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Question 1:");

                // Constants for question 1
                const int Index = 13;
                int sum = 0;
                int k = 0;

                // Calculate sum
                SumCalculator sumCalculator = new SumCalculator(Index, sum, k);
                sumCalculator.SumValue(Index);

                Console.WriteLine(sumCalculator);
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please enter a valid integer number.");
            }

            try
            {
                Console.WriteLine("Question 2:");

                // Instantiating the Fibonacci service
                IFibonacciService fibonacciService = new FibonacciService();

                // Asking the user for a number to check if it belongs to the Fibonacci sequence
                Console.Write("Enter a number to check if it belongs to the Fibonacci sequence: ");
                int number = Convert.ToInt32(Console.ReadLine());

                // Checking if the number belongs to the Fibonacci sequence and displaying the result
                bool belongs = fibonacciService.CheckBelongsToSequence(number);

                if (belongs)
                    Console.WriteLine($"{number} belongs to the Fibonacci sequence.");
                else
                    Console.WriteLine($"{number} does not belong to the Fibonacci sequence.");
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please enter a valid integer number.");
            }
            catch (FibonacciSequenceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                Console.WriteLine("Question 5:");

                // Instantiate the service
                IStringReverser stringReverser = new StringReverserService();

                // Input string
                Console.Write("Enter a word: ");
                string input = Console.ReadLine();

                // Reverse the string using the service
                string reversedString = stringReverser.ReverseString(input);
                StringReverse stringReverse = new StringReverse(input, reversedString);
                Console.WriteLine(stringReverse);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please enter a valid string.");
            }

            Console.ReadLine();
        }
    }
}
