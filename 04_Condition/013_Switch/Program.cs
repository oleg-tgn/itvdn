using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_Switch
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
                    Console.WriteLine("Понедельник.");
                    break;
                case 2:
                    Console.WriteLine("Вторник.");
                    break;
                default:
                    Console.WriteLine("И т.д.");
                    break;
            }
        }
    }
}
