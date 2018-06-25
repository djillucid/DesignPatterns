using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MyClass
    {

        public int num1;
        public int num2;
        public int num3;
        public  IAlgorithm alg;

        public MyClass()
        {
            num1 = 10;
            num2 = 14;
            num3 = 18;
            alg = new Multiply();
        }

        public MyClass(int num1, int num2, int num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            alg = new Multiply();
        }

        public MyClass(int num1, int num2, int num3, IAlgorithm alg)
        {
            num1 = 10;
            num2 = 14;
            num3 = 18;
            this.alg = alg;
        }

        public int Calculate() {



            return this.alg.Calculate(this.num1, this.num2, this.num3);
        }



    }
}
