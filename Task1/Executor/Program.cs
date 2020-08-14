using System;
using Task1;

namespace Executor
{
	class Program
	{
		static void Main(string[] args)
		{
			var intArray = new int[] { 1, -2, 3, 4, 2, 2, 3, 5, 2, -1 };
			var result = Helper.FindPairs(ref intArray);
			foreach (var item in result)
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.WriteLine($"Absolute is {item.Key}. Any pairs from combination from two list: ");
				Console.BackgroundColor = ConsoleColor.Cyan;
				foreach (var p1 in item.Value.Item1)
				{
					
					Console.Write($"{p1} ");
				}

				Console.WriteLine();
				Console.BackgroundColor = ConsoleColor.DarkGreen;
				foreach (var p1 in item.Value.Item2)
				{
					Console.Write($"{p1} ");
				}

				Console.WriteLine();
			}
		}
	}
}
