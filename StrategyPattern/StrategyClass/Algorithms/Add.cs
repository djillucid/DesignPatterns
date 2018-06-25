using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.StrategyClass.Algorithms
{
    class Add : IAlgorithm
    {
        public int Calculate(int a, int b, int c)
        {
            return (a+b+c);
        }

        public string GetName()
        {
            return "Add";
        }
    }
}
