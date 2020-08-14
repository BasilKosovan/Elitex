using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public  static partial class Helper
	{

		public static void SortBoolArray(ref bool[] array)
		{

			int i = 0;
			int j = array.Length - 1;
			int length = array.Length;

			while (i < j)// <=N operations 
			{
				while (i < length - 1 && array[i])// <= N
				{
					i++;
				}

				if (i >= j)
				{
					return;
				}

				while (j > 0 && array[j] && !array[j]) // <= N
				{
					j--;
				}

				if (i <j)
				{
					array[i] = false;
					array[j] = true;
				}
				i++; j--;
			}

			//O(N) + O(N) +O (N) ~ O(N)
		}

	}
}

