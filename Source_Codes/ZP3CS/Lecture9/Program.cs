using System;

namespace Lecture9
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void CustomCollectionOverview()
        {
            var intList = new IntList();
            intList.Add(4);
            intList.Add(3);
            intList.Add(2);
            intList.Add(2);
            intList.Add(1);

            Console.WriteLine(intList.Count);
            Console.WriteLine(intList.ToString());

            Console.WriteLine(intList[0]);
            intList[0] = 0;
            Console.WriteLine(intList.ToString());

            intList.Remove();
            intList.Sort();
            Console.WriteLine(intList.ToString());

            Console.WriteLine(intList.IndexOf(2));
            Console.WriteLine(intList.LastIndexOf(2));

            Console.WriteLine(intList.EvenNumbers(500).ToString());

            var listInt2 = new IntList();
            listInt2.Add(4);
            listInt2.Add(2);
            listInt2.Add(10);

            Console.WriteLine((intList + listInt2).ToString());
            Console.WriteLine((intList - listInt2).ToString());
        }

        static IntList EvenNumbers(this IntList intList)
        {
            var newList = new IntList();

            foreach (var number in intList)
            {
                if (number % 2 == 0)
                {
                    newList.Add(number);
                }
            }

            return newList;
        }
    }
}
