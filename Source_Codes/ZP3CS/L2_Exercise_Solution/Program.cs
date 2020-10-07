using System;
using System.Collections.Generic;

namespace L2_Exercise_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Calculator()
        {
            try
            {
                var operation = ReadOperation();
                var numberOfOperands = operation == CalculatorOperation.Pow ? 2 : ReadNumberOfOperands();
                var operands = ReadOperands(numberOfOperands);
                PrintResult(operands, operation);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Unsupported operation.");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static int ReadNumberOfOperands()
        {
            Console.WriteLine("Enter number of operands: ");
            var numberOfOperands = Console.ReadLine();
            return int.Parse(numberOfOperands);
        }

        static CalculatorOperation ReadOperation()
        {
            Console.WriteLine("Enter operation: ");
            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    return CalculatorOperation.Addition;
                case "-":
                    return CalculatorOperation.Subtraction;
                case "*":
                    return CalculatorOperation.Multiplication;
                case "/":
                    return CalculatorOperation.Division;
                case "^":
                    return CalculatorOperation.Pow;
                default:
                    throw new InvalidOperationException();
            }
        }

        static List<int> ReadOperands(int numberOfOperands)
        {
            var operands = new List<int>();

            for (var i = 1; i <= numberOfOperands; i++)
            {
                Console.WriteLine($"Enter operand number {i}: ");

                // To keep it simple we will expect only integers...
                var number = Console.ReadLine();
                operands.Add(int.Parse(number));
            }

            return operands;
        }

        static void PrintResult(List<int> operands, CalculatorOperation operation)
        {

            if (operation == CalculatorOperation.Addition)
            {
                var result = 0;

                foreach (var operand in operands)
                {
                    result += operand;
                }

                Console.WriteLine($"Result is: {result}");
            }
            else if (operation == CalculatorOperation.Pow)
            {
                var result = Math.Pow(operands[0], operands[1]);
                Console.WriteLine($"Result is: {result}");
            }
            // ...
        }

        static string ReplaceName(string name)
        {
            var replacementString = "xxxxxxxxxx";
            replacementString = replacementString.Replace("x", "xxxxxxxxxx");
            replacementString = replacementString.Replace("x", "xxxxxxxxxx");
            replacementString = replacementString.Replace("x", $"{name}, ");

            return replacementString;
        }

        static void ReplaceVowels()
        {
            Console.WriteLine("Enter phrase: ");
            var phrase = Console.ReadLine();

            foreach (var letter in phrase)
            {
                if ("AEIOUY".Contains(letter))
                {
                    phrase = phrase.Replace(letter, 'M');
                    continue;
                }

                if ("aeiouy".Contains(letter))
                {
                    phrase = phrase.Replace(letter, 'm');
                    continue;
                }
            }

            Console.WriteLine(phrase);
        }
    }
}
