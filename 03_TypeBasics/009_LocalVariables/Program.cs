using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_LocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 22;
            {
                int a = 1;
                Console.WriteLine(b);
            }

            {
                int a = 2;
            }
        }
    }
}
