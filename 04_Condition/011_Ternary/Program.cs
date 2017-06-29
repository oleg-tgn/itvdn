using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            double q = 10;
            double p = 100;
            double d = 0.75;
            double cost;

            cost = q >= 10 ? q * p * d : q * p;

            Console.WriteLine(cost);

            Console.ReadKey();
        }
    }
}
