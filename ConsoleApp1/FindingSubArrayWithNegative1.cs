using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class FindingSubArrayWithNegative1
    {


        public static void subArraymeetSum(int[] arr, int n, int sum)
        {
            //cur_sum to keep track of cumulative sum till that point
            int cur_sum = 0;
            int start = 0;
            int end = -1;
            Dictionary<int, int> SumDic = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                cur_sum = cur_sum + arr[i];
                
                if (cur_sum - sum == 0)
                {
                    start = 0;
                    end = i;
                   Console.WriteLine("Sum found between indexes " + start + " to " + end);
                  
                }
               
                if (SumDic.ContainsKey(cur_sum - sum))
                {
                    start = SumDic[cur_sum - sum] + 1;
                    end = i;
                   Console.WriteLine("Sum found between indexes " + start + " to " + end);
                   
                }

                SumDic[cur_sum] = i;

            }
         
            if (end == -1)
            {
                Console.WriteLine("No subarray with given sum exists");
            }
           
        }

        // Driver code
        public static void main()
        {
            //int[] a = new int[] { 10, 2, -2, -20, 10,5 };
            //int n = a.Length;
            //int sum = -10;

            //int[] a = { 1, 4, 20, 3, 10, 23 };

            //int n = a.Length;
            //int sum = 33;

            //int[] a = { 10, 2, -2, -20, 10 };
            //int n = a.Length;
            //int sum = 0;

            int[] a = { 1, 4 };
            int n = a.Length;
            int sum = 0;


            //int[] a = {-2, 1, -3, 4, -1, 2, 1, -5, 4};

            //int n = a.Length;
            //int sum = 6;
            subArraymeetSum(a, n, sum);

        }
    
}
}
