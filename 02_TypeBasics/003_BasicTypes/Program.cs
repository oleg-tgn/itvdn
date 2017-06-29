using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ЦЕЛЫЕ ТИПЫ

            // 8-bits == 1 byte
            byte a = 0;
            Byte b = 255;

            // ......
            #endregion

            #region ВЕЩЕСТВЕННЫЕ ЧИСЛА
            
            //32-bits
            float q;
            Single r;

            //64-bits
            double s;
            Double t;

            #endregion

            #region ДЕСЯТИЧНЫЙ ТИП

            decimal u;
            Decimal v;
            
            #endregion

            #region ЛОГИЧЕСКИЙ ТИП

            bool w = true;
            Boolean x = false;

            #endregion

            #region СИМВОЛЬНЫЙ ТИП

            char y = 'a';
            Char z = 'A';

            #endregion

            #region СТРОКОВОЙ ТИП

            string str = "hello";
            String str2 = "hello";

            #endregion
        }
    }
}
