using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
   public  interface IAlgorithm
    {

       
        int Calculate(int a, int b, int c);
        string GetName();

    }
}
