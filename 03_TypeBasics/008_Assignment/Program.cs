using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правило:
            // Все операции производимые на двумя значениями типа (byte, sbyte, short, ushort)
            // в качестве результата возвращают int

            byte var1 = 0;
            var1 = (byte)(var1 + 5);
            var1 += 5;

            // Для типов int, uint, long и ulong не просходит типа результата арифметических операций
        }
    }
}
