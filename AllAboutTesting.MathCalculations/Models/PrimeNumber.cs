using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAboutTesting.MathCalculations.Models
{
    public class PrimeNumber
    {
        public int AnInteger { get; set; }

        public PrimeNumber(int anInteger)
        {
            AnInteger = anInteger;
        }

        public bool IsPrime()
        {
            bool ans = false;
            int i, m = 0, flag = 0;
            
            m = AnInteger / 2;

            for (i = 2; i <= m; i++)
            {
                if (AnInteger % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
                ans = true;

            return ans; 
        }
    }
}
