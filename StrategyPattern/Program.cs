using System;
using System.Collections.Generic;
using StrategyPattern.StrategyClass.Algorithms;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //There is the strategy interface that demands a calculate method
            //There are two different strategies that implement that interface
            //Finally, a class that contains some ints and a concrete object that implements the strategy interface
            //The proram below creates the object with a default strategy, calculates, changes during run time the
            //strategy for a different one and displays the result to the console


            //for fun I made a collection of the different algorithms so I can iterate through each of them
            List<IAlgorithm> algList = new List<IAlgorithm>();
            algList.Add(new Multiply());
            algList.Add(new ReturnLargestAlgorithm());
            algList.Add(new ReturnLowestAlgorithm());
            algList.Add(new Add());

            MyClass mc = new MyClass(24, 1, 2);
            Console.WriteLine("Running through algorithms\n");

            foreach (var alg in algList)
            {
                mc.alg = alg;
                Console.WriteLine(alg.GetName());
                Console.WriteLine("Numbers are {0},{1},{2} and the result is: {3}\n", mc.num1, mc.num2, mc.num3, mc.Calculate());
            }

            Console.ReadLine();


        }
    }
}
