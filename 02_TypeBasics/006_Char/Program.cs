using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = '\x0041'; // 16-ричный формат
            char c = '\u0041'; // unicode

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
