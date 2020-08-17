using System;
using System.Collections.Generic;

namespace TestTasks
{
    public static partial class Helper
    {
        public static Dictionary<int, Tuple<List<int>, List<int>>> FindPairs(ref int[] array)
        {
            var dictionary = new Dictionary<int, List<int>>(); //<=O(N)
            List<int> hashValue;//O(1)
            var result = new Dictionary<int, Tuple<List<int>, List<int>>>(); // <= O(N/2) items
                                                                             //array O(N)			

            //Space complexity: O(N) + O(1) + O(N/2) + O(N) ~ O(N)
            for (int i = 0; i < array.Length; i++) // O(N)
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

            foreach (var item in dictionary.Keys) // <= N operations // O(N)
            {
                hashValue = null;
                dictionary.TryGetValue(0 - item, out hashValue);
                if (hashValue != null && !result.ContainsKey(Math.Abs(item)))
                {
                    result.Add(Math.Abs(item), new Tuple<List<int>, List<int>>(dictionary[item], hashValue));
                }
            }
           
            //Time complexity: O(N) + O(N) ~ O(N)
            return result;
        }

    }
}

