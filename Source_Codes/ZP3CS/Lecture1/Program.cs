using System;
using System.Collections.Generic; // This import enables us to use array certain type => List<int>

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void ForLoopExample()
        {
            for (int i = 0; i < 10; i++)
            {
                // implicit conversion to string
                Console.WriteLine(i);
            }
        }

        static void IfStatementExample(int myNumber)
        {
            if (IsEvenNumber(myNumber))
            {
                Console.WriteLine("Hello");
            }
            else if (myNumber > 10)
            {
                Console.WriteLine("World");
            }
            else
            {
                Console.WriteLine("Hello world!");
            }
        }

        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        static void ArraysAndListsExample()
        {
            // static array declaration
            var myArray = new int[5];

            for (var i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            // Error => 'Index was outside the bounds of the array.'
            // myArray[5] = 1;
            // This problem can be solved by using List.

            var myList = new List<int>();

            for (var i = 0; i < 10; i++)
            {
                myList.Add(i);
            }

            // Accessing list values by index 
            Console.WriteLine("Value in list " + myList[0]);
        }
    }
}
