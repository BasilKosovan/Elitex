using System;

namespace TestTasks
{
    public static partial class Helper
    {
        private static void Reverse(int[] arr, int start, int end)
        {
            int temp; // O(1)
            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public static void Rotate(int[] array, int k)
        {
            if (k < 0)
            {
                throw new ArgumentException("k must be more than 0");
            }

            if (k == 0)
            {
                return;
            }
            if (k >= array.Length)
            {
                k = k % array.Length;
                if (k == 0)
                {
                    return;
                }
            }


            Reverse(array, 0, array.Length - k - 1); //TC: O(N-C) | SC: O(1)
            Reverse(array, array.Length - k, array.Length - 1); //TC: O(C) | SC: O(1)
            Reverse(array, 0, array.Length - 1); //TC: O(N) | SC: O(1)

            //Space complexity: O(1) + O(1) + O(1) ~ O(1)
            //Time complexity: O(N-C) + O(C) + O(N) ~ O(N)
        }
    }
}

