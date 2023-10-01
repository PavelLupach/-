using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор2
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите превое число: ");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();
            
            Console.WriteLine("Введите второе число: ");
            secondValue = double.Parse(Console.ReadLine());

            if (action =="+")
            {
                Console.WriteLine(firstValue + secondValue);
            }
            else if (action == "-")
            {
                Console.WriteLine(firstValue - secondValue);
            }
            else if (action == "*")
            {
                Console.WriteLine(firstValue * secondValue);
            }
            else if (action == "/")
            {
                if (secondValue == 0)
                    Console.WriteLine("НА НУЛЬ ДЕЛИТЬ НЕЛЬЗЯ!");
                else
                    Console.WriteLine(firstValue / secondValue);
            }
            else
            {
                Console.WriteLine("Я без понятия что с этим делать");
            }

            Console.ReadLine();

        }
    }
}
