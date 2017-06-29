using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Неявное (безопасное) преобразование типа
            
            byte a = 10; // 1 байт
            int b = 0; // 4 байта
            b = a;

            #endregion

            #region Явное (небезопасное) преобразование типа

            int e = 256;
            byte f = 0;
            f = (byte)e;

            #endregion

            #region Кастинг констант

            // Константа не превышает максимального допустимого значения
            const int i = 255;
            byte j = 0;
            j = i;

            #endregion

        }
    }
}
