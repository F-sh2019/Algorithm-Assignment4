using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ClassLargestSum
    {



		public static void FindingLargestSubArray(int[] a, int n)
		{
			int SumMax = int.MinValue;
			int CurrentMax = 0;
			int PStart = 0;
			int PEnd = 0;
		
			 for (int i = 0; i <= n - 1; i++)
			{
				CurrentMax = CurrentMax + a[i];
				if (CurrentMax >= SumMax)
				{
					SumMax = CurrentMax;
					PEnd = i;
				}
				if (CurrentMax < 0)
				{
					CurrentMax = 0;
					PStart = i+1;
				}
			}

			for (int j = PStart; j <= PEnd; j++)
				Console.Write(a[j]);

			Console.Write("The largetSum is "+ SumMax);
		}


		public static void main()
		{
			int[] a = { -1, -2, -3};
			int n = a.Length;
			FindingLargestSubArray(a, n);


		}
	}
}
