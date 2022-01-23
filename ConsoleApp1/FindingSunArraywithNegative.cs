using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindingSunArraywithNegativr
    {

        public static void FindingSubarrayMeetAdd(int[] a, int GivenValue)
        {
            int s = 0, i = 0;
            int  CurrentSum = a[0];
            bool foundSunArray = false;
            
            int n = a.Length;

            for (i = 1; i <= n - 1; i++)
            {

                CurrentSum = CurrentSum + a[i];

                if (CurrentSum > GivenValue)
                {
                    while (CurrentSum > GivenValue && GivenValue>=0)
                    {
                        CurrentSum = CurrentSum - a[s];
                        if (s < n - 1)
                        {
                            s = s + 1;
                        }
                    }
                }
                if (CurrentSum == GivenValue && i >= s )
                {
                    foundSunArray = true; 
                    Console.WriteLine("the sum between index " + s + " and index " + i);
                    CurrentSum = CurrentSum - a[s];
                    if (s < n - 1 )
                    {
                        s = s+1;
                    }
                }
                if (CurrentSum == 0 && CurrentSum != GivenValue)
                {
                    s = i;
                    CurrentSum = a[s];

                }
              
                else if ((CurrentSum == GivenValue && i < s) || (CurrentSum != GivenValue && s == n - 1))
                {
                    if (!foundSunArray) Console.WriteLine("There is no subarray");

                }

            }
        }



        public static void main()
        {
            //int[] a = { 1, 4, 20, 3, 10, 23 };
            //int givenvalue = 33;

            //int[] a = { 10, 2, -2, -20, 10 };
            //int givenvalue = 0;

            //int[] a = { 1, 4 };
            //int givenvalue = 0;


            //int[] a = { 1, 10, -6, 15, 13, 20, 3, 10, 23 };
            //int givenvalue = 33;


            //int[] a = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };


            //int givenvalue = 6;

            int[] a = { 1, 0, 4, 0, -1, -4, 4 };
            int givenvalue = 0 ;

            FindingSubarrayMeetAdd(a, givenvalue);


        }

    }
}
