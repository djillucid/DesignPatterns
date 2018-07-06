using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class HardCandyStore : CandyStore
    {
        public override Candy CreateCandy(string type)
        {
            throw new NotImplementedException();
        }
    }
}
