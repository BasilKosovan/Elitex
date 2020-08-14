using System;
using System.Collections.Generic;

namespace Task1
{
	public static partial class Helper
	{
		public static new Dictionary<int, Tuple<List<int>, List<int>>> FindPairs(ref int[] array)
		{
			var dictionary = new Dictionary<int, List<int>>(); //max N items
			List<int> hashValue;
			var result = new Dictionary<int, Tuple<List<int>, List<int>>>(); // max N/2 items

			for (int i = 0; i < array.Length; i++) // N operations
			{
				hashValue = null;
				dictionary.TryGetValue(array[i], out hashValue);
				if (hashValue != null)
				{
					hashValue.Add(i);
				}
				else
				{
					dictionary.Add(array[i], new List<int> { i });
				}
			}

			foreach (var item in dictionary.Keys) // <= N operations
			{
				hashValue = null;
				dictionary.TryGetValue(0 - item, out hashValue);
				if (hashValue != null && !result.ContainsKey(Math.Abs(item)))
				{
					result.Add(Math.Abs(item), new Tuple<List<int>, List<int>>(dictionary[item], hashValue));
				}
			}

			return result;
		}

	}
}

