using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "Admin";

            Console.WriteLine("Введите Login: ");

            string userLogin = Console.ReadLine();

            if (login == userLogin)
            {
                Console.Write("Верный логин");
            }

            Console.ReadKey();

        }
    }
}
