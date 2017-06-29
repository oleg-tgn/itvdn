using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 2;

            if (a < b)            
                Console.WriteLine("a < b");            
            else            
                Console.WriteLine("a не меньше b");            

            Console.ReadKey();
        }
    }
}
