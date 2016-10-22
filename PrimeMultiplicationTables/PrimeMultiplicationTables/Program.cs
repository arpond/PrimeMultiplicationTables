using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeMultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Please enter the Number of Primes you wish to generate a multiplication table for or 'q' to quit\n>> ");
                bool validInput = false;
                int numberOfValues = 0;
                String input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    Environment.Exit(0);
                }

                do
                {
                    var validatedInput = Controller.ValidateInput(input);
                    validInput = validatedInput.Item1;
                    numberOfValues = validatedInput.Item2;

                    if (!validInput)
                    {
                        Console.WriteLine("The input must be a positive integer.");
                        Console.Write("Please enter the Number of Primes you wish to generate a multiplication table for or 'q' to quit\n>> ");
                        input = Console.ReadLine();
                    }
                } while (!validInput);

                var table = Controller.GenerateTableForNValues(numberOfValues);
                Console.Write(table);
            } while (true);
        }
    }
}
