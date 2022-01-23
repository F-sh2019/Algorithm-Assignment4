using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class sortarraybyfrequency
    {
        public static  void sortarray(int[] a,int n)

        {
            MyOwnType ArrInfo ;
            Dictionary<int, MyOwnType> MyDic = new Dictionary<int, MyOwnType>() ;

            for (int i = 0; i <= n - 1; i++)
            {
                             
                if (MyDic.ContainsKey(a[i]))
                {
                    ArrInfo = new MyOwnType(MyDic[a[i]]._index, MyDic[a[i]]._frequency + 1);
                    MyDic[a[i]] = ArrInfo;

                }
                else
                {
                 ArrInfo = new MyOwnType(i, 1);
                 MyDic.Add(a[i], ArrInfo);
                  }
           
            }

            //sorting dictionary by frequency and Index value
 
            var s= MyDic.OrderByDescending(x => x.Value._frequency).ThenBy(x => x.Value._index).ToList();

            int j = 0;
           
           
            
            foreach(KeyValuePair<int, MyOwnType> entry in s )
            {
                Console.WriteLine(" Key={1}, Value={2}", entry.Key, entry.Value._frequency , entry.Value._index);

                for (int i = j; i <= j+ entry.Value._frequency - 1; i++)
                {
                    a[i] = entry.Key;
                    
                }
                j = j+ entry.Value._frequency;
            }

            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] +" , ");
            }

            
        }

        public static void main()
        {
            int[] a = { 2, 5, 2, 8, 5, 6, 8, 8 };
            
            //int[] a = { 1, 4, 0, 0, 3, 10, 5 };
            
            
            
            int n = a.Length;

         

            sortarray(a, n);


        }

    }
}
