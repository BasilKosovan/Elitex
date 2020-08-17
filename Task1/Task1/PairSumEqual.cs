using System;
using System.Collections.Generic;

namespace TestTasks
{
    public static partial class Helper
    {
        public static Dictionary<int, Tuple<List<int>, List<int>>> FindPairs(int[] array1, int[] array2)
        {
            var dictionary = new Dictionary<int, List<int>>(); //<=O(N1)
            List<int> hashValue;//O(1)
            var result = new Dictionary<int, Tuple<List<int>, List<int>>>(); // <= O(N1/2) items


            //Space complexity: O(N1) + O(1) + O(N/2)  ~ O(N1)
            for (int i = 0; i < array1.Length; i++) // O(N1)
            {
                hashValue = null;
                if (dictionary.TryGetValue(array1[i], out hashValue))
                {
                    hashValue.Add(i);
                }
                else
                {
                    dictionary.Add(array1[i], new List<int> { i });
                }
            }

            for (int i = 0; i < array2.Length; i++)  // O(N2)
            {
                hashValue = null;
                if (dictionary.TryGetValue(0 - array2[i], out hashValue) && !result.ContainsKey(array2[i]))
                {
                    result.Add(array2[i], new Tuple<List<int>, List<int>>(new List<int> { i }, hashValue));
                }
                else
                {
                    result[array2[i]].Item1.Add(i);
                }
            }

            //Time complexity: O(N1) + O(N2) ~ O(N)
            return result;
        }

    }
}

