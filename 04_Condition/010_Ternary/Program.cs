using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = -5;

            string q = x > 0 ? (y > 0 ? "I" : "IV") : (y > 0 ? "II" : "III");
        }
    }
}
