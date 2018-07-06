using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ChocolateStore : CandyStore
    {
        public override Candy CreateCandy(string type)
        {
            if (type == "Snickers")
            {
                //todo make different types of candy besides the default below

                return new Candy();
            }

            else if(type == "Reeses")
            {
                //todo make different types of candy besides the default below
                return new Candy();
            }

            else if(type == "BarWithAlmonds")
            {
                //todo make different types of candy besides the default below
                return new Candy();
            }

            else
            {
                return new Candy();
            }
        }
    }
}
