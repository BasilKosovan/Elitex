using System;
using System.Collections.Generic;
using TestTasks;

namespace Executor
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPairSumQqual();
            //TestRotateMethod();
            //TestSortBoolArray();
        }

        private static void TestSortBoolArray()
        {
            var listOfBoolArrays = new List<bool[]>();
            listOfBoolArrays.Add(new bool[] { true, false, false, true, true });
            listOfBoolArrays.Add(new bool[] { false, false, false, true, true });
            listOfBoolArrays.Add(new bool[] { true, true });
            listOfBoolArrays.Add(new bool[] { false, false });
            listOfBoolArrays.Add(new bool[] { true });
            listOfBoolArrays.Add(new bool[] { false });
            for (int i = 0; i < listOfBoolArrays.Count; i++)
            {
                var array = listOfBoolArrays[i];
                Helper.SortBoolArray(array);
            }
        }

        private static void TestRotateMethod()
        {
            var intArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Helper.Rotate(intArray, 3);
            Helper.Rotate(intArray, 9);
            Helper.Rotate(intArray, 10);
            Helper.Rotate(intArray, 0);
        }

        private static void TestPairSumQqual()
        {
            var intArray1 = new int[] { 1, 2, 3, -1, -1, -2, -2, -3 };
            var intArray2 = new int[] { -1, -2, -3, 1, 2, 2 };
            var result = Helper.FindPairs(intArray1, intArray2);
            foreach (var item in result)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Absolute is {item.Key}. Any pairs where i from the first list and j from the second list ");
                Console.BackgroundColor = ConsoleColor.Cyan;
                foreach (var p1 in item.Value.Item2)
                {

                    Console.Write($"{p1} ");
                }

                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                foreach (var p1 in item.Value.Item1)
                {
                    Console.Write($"{p1} ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

