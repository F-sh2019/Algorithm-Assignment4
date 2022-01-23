using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ArraysLeaders
    {
   
            void FindLeaders(int[] arr, int n)
            {
                int Right_max = arr[n - 1];

                
                Console.Write(Right_max + " ");

                for (int i = n - 2; i >= 0; i--)
                {
                    if (Right_max < arr[i])
                    {
                       Right_max = arr[i];
                        Console.Write(Right_max + " ");
                    }
                }
            }

            // Driver Code
            public static void main()
            {
                  ArraysLeaders lead = new ArraysLeaders();
                int[] a = new int[] { 16, 17, 4, 3, 5, 2 };
                int n = a.Length;
                lead.FindLeaders(a, n);
            }
        
    }
}
