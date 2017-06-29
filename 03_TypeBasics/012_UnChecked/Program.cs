using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_UnChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;

            unchecked
            {
                a++;
            }

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
