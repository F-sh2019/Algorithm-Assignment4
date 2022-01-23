using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindingSunArraynonNegativr
    {

        public static void FindingSubarrayMeetAdd(int[] a, int GivenValue)
        {
            int s = 0, i = 0;
            int CurrentSum = 0;

            int n = a.Length;

            for (i = 0; i <= n - 1; i++)
            {

                CurrentSum = CurrentSum + a[i];

                if (CurrentSum > GivenValue)
                {
                    while (CurrentSum > GivenValue)
                    {
                        CurrentSum = CurrentSum - a[s];
                        s = s + 1;
                    }
                }
                if (CurrentSum == GivenValue && i >= s)
                {
                    
                    Console.WriteLine("the sum between index" + s + " and index " + i);
                    return;
                }
                else if (CurrentSum == GivenValue && i < s)
                { 
                    Console.WriteLine("There is no subarray");
                    return;
                }

            }
        }



        public static void main()
        {
            //int[] a = { 1, 4, 20, 3, 10, 5 };
            //int givenvalue = 33;

            //int[] a = { 1, 4, 0, 0, 3, 10, 5 };
            //int givenvalue = 7;

            int[] a = { 1, 4 };
            int givenvalue = 0;

            FindingSubarrayMeetAdd(a, givenvalue);


        }

    }
}
