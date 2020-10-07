using System;
using System.Text;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StringBuilderExample());
            Console.Write("Press some key: ");
            // returns ASCII representation
            char charInput = (char)Console.Read();
            Console.WriteLine(charInput);
        }

        static void StringBasics()
        {
            var myString = "Hello";

            // Gets number of characters in string.
            var len = myString.Length;
            for (var i = 0; i < len; i++)
            {
                // string interpolation
                Console.Write($"{i + 1}: {myString[i]}, ");
            }

            Console.WriteLine();

            var j = 1;
            foreach (var character in myString)
            {
                // string format
                Console.Write("{0}: {1}, ", j, character);
                j++;
            }

            // + operation can be used for strings to append them
            myString += "World!";
            Console.WriteLine(myString);
        }

        // other examples and usage can be found here: https://docs.microsoft.com/cs-cz/dotnet/api/system.string?view=netcore-3.1
        static void StringMethods()
        {
            var myString = "foo moo blah 42";
            Console.WriteLine(myString.StartsWith("foo"));
            Console.WriteLine(myString.EndsWith("!"));
            Console.WriteLine(myString.Contains("blah"));

            // returns index of first occurence
            Console.WriteLine(myString.IndexOf('m'));
            // returns starting index of first occurence
            Console.WriteLine(myString.IndexOf("mo"));


            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.ToLower());

            Console.WriteLine(myString.Replace('m', 'f'));
        }

        static void SwitchExample()
        {
            int number = 10;
            switch (number)
            {
                case 1:
                    Console.WriteLine("That was number one.");
                    break;
                case 2:
                    Console.WriteLine("That was number two.");
                    break;
                default:
                    Console.WriteLine("That was some other number");
                    break;
            }
        }

        static void MethodOverload()
        {
            Console.WriteLine("Method overload example 1.");
        }

        static void MethodOverload(int i)
        {
            Console.WriteLine("Method overload example 1.");
        }

        // Overload affects only parameters not return type.
        //static int MethodOverload()
        //{
        //    Console.WriteLine("Method overload example 1.");
        //    return 1;
        //}

        static void UserInputExample()
        {
            Console.Write("Enter some line: ");
            var stringInput = Console.ReadLine();
            Console.WriteLine(stringInput);

            Console.Write("Press some key: ");
            // returns ASCII representation
            var charInput = Console.Read();
            Console.WriteLine(charInput);
        }

        static void ParsingExample()
        {
            string myString = "42";
            Console.WriteLine(myString + 1);

            int myInt = Convert.ToInt32(myString);
            Console.WriteLine(myInt + 1);

            int myInt2 = int.Parse("42");
            Console.WriteLine(myInt2 + 1);
        }

        static void SafeParsingExample()
        {
            Console.Write("Enter some number: ");
            var userInput = Console.ReadLine();
            int number;

            try
            {
                number = int.Parse(userInput);
                Console.WriteLine(number + 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(":(");
            }

            int number2;
            if (int.TryParse(userInput, out number2) == false)
            {
                Console.WriteLine("That didn't go so well :(");
            }
            else
            {
                Console.WriteLine(number2 + 1);
            }
        }

        static string StringBuilderExample()
        {
            var builder = new StringBuilder("Hello");

            for (int i = 0; i < 100; i++)
            {
                builder.Append("\n Hello");
            }

            return builder.ToString();
        }
    }
}