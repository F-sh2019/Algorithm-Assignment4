using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindingEquilibriumIndex
    {

        public static int findingEquiIndex(int[] nums, int n)
        {
            int sum = 0;
           
            int leftsum = 0;

            
            for (int i = 0; i < n; ++i)
                sum += nums[i];

            for (int i = 0; i < n; ++i)
            {

                
                sum -= nums[i];

                if (leftsum == sum)
                    return i;

                leftsum += nums[i];
            }

         
            return -1;
        }



        public static void main()
        {
            int[] a = { 1, 4, 20, 3, 10, 15 };
            int n = a.Length;
            int i= findingEquiIndex(a, n);
            Console.WriteLine(i);
        }
    }
}
