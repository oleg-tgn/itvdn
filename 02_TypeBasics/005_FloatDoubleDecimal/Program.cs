using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_FloatDoubleDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            float v1 = 0.123456789012345678901234567890123456789012345678901234567890f;
            double v2 = 0.12345678901234567890123456789123456789012345678901234567890d;
            decimal v3 = 0.123456789012345678901234567890123456789012345678901234567890m;

            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

            Console.ReadKey();
        }
    }
}
