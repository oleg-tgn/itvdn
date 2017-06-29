using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_CoffeeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выбирите размер кофе: 1 - Маленький, 2 - Средний, 3 - Большой");
            string coffeeSize = Console.ReadLine();

            int cost = 0;

            // Если оператор case имеет в своем теле код, то не поддерживается "проваливание"
            // Для организации "проваливания" можно использовать оператор бузусловного перехода - goto
            switch (coffeeSize)
            { 
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста выбирите 1, 2 или 3.");
                    break;
            }

            if (cost != 0)
            {
                Console.WriteLine("Внесите {0} копеек", cost);
                Console.WriteLine("Спасибо!");
            }
            else 
            {
                Console.WriteLine("Пожалуйта, повторите выбор.");
            }

            Console.ReadKey();
        }
    }
}
