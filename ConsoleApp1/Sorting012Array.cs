using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Sorting012Array
    {


        private static void SortingArray(int[] a, int n)

        {
            int ZeroIndex = 0;
            int TwoIndex = n - 1;
            int OneIndex = 0, temp = 0;

            while (OneIndex <= TwoIndex)
            {
                switch (a[OneIndex])
                {
                    case 0:
                        {
                            temp = a[ZeroIndex];
                            a[ZeroIndex] = a[OneIndex];
                            a[OneIndex] = temp;
                            ZeroIndex++;
                            OneIndex++;
                            break;
                        }
                    case 1:
                        OneIndex++;
                        break;
                    case 2:
                        {
                            temp = a[OneIndex];
                            a[OneIndex] = a[TwoIndex];
                            a[TwoIndex] = temp;
                            TwoIndex--;
                            break;
                        }
                }



               
            }
            for (int i = 0; i <= n - 1; i++)
                Console.Write(a[i]);
        }


        public static void main()
        {
            int[] arr = { 0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1 };
            int arr_size = arr.Length;
            SortingArray(arr, arr_size);


        }
    }
}
