using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class CandyStore
    {
        public Candy orderCandy(string type) {

            Candy candy = CreateCandy(type);
            candy.Prepare();
            candy.Package();

            return candy;
        }

        public abstract Candy CreateCandy(string type);

    }
}
