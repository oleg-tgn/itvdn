using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_CheckedUnChecked
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 126;
            sbyte b = 127;

            checked
            {
                a++;

                unchecked
                {
                    b++;
                }

                a++;
            }

            
        }
    }
}
