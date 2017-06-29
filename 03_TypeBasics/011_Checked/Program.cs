using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;

           // checked
            //{
                a++;
           // }

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
