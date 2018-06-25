using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Multiply : IAlgorithm
    {

        int IAlgorithm.Calculate(int a, int b, int c)
        {
            return (a * b * c);

        }

        public string GetName() {
            return "Multiply";
        }
    }
}
