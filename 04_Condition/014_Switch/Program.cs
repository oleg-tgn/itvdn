using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string myDay = Console.ReadLine();

            int day = Convert.ToInt32(myDay);

            switch (day)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Рабочий.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Выходной.");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
