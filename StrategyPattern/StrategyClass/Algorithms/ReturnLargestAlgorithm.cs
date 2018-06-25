using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public  class ReturnLargestAlgorithm : IAlgorithm
    {
        public int Calculate(int a, int b, int c)
        {
            int tmp = a;
            if (b > tmp)
            {
                tmp = b;
            }

            if (c > tmp)
            {
                tmp = c;
            }

            return tmp;

        }


        public string GetName()
        {
            return "Return Highest Number";
        }
    }
}
