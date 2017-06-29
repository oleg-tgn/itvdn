using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    {
                        Console.WriteLine("Один");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Два");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Много");
                        break;
                    }
            }
        }
    }
}
