namespace TestTasks
{
    public  static partial class Helper
	{
		public static void SortBoolArray(ref bool[] array)
		{

			int i = 0; //O(1)
			int j = array.Length - 1; //O(1)
			int length = array.Length; //O(1)
									   //array O(N)

			//Space complexity: O(1) + O(1) + O(1) + O(N) ~ O(N)

			while (i < j)// <=N operations 
			{
				while (i < length - 1 && !array[i])// <= N
				{
					i++;
				}

				if (i >= j)
				{
					return;
				}

				while (j > 0 && array[j] && array[j]) // <= N
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

			//Time complexity: O(N) + O(N) +O (N) ~ O(N)
		}
	}
}

