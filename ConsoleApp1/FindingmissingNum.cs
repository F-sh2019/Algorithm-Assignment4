using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindingmissingNum
    {

        public static int findingMissedNumer(int[] a, int n)
        {
            int SigmaN = 0;
            if (n < 1)
            {
                return 0;
            }
            SigmaN = (n + 1) * (n + 2) / 2;
            int sum=0;
            for (int i = 0; i <= n - 1; i++)
                sum = sum + a[i];
            
            
            
            
            return (SigmaN - sum);


        
        }
    }
}
