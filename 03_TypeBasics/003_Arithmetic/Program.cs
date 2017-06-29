using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5, b = 2;
            int q = a / b;
            int r = a % b;

            Console.WriteLine(q);
            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
