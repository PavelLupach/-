using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УСРС2
{
    class Program
    {
        static void Main(string[] args)
        {
            double fValue, sValue;
            string action;

            Console.WriteLine("Введите первое число: ");
            fValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
            action = Console.ReadLine();

            Console.WriteLine("Введите второе число: ");
            sValue = double.Parse(Console.ReadLine());

            switch (action)
            {
               
                
                case "+":
                    Console.WriteLine(fValue + sValue);
                break;

                case "-":
                    Console.WriteLine(fValue - sValue);
                break;

                case "*":
                    Console.WriteLine(fValue * sValue);
                break;

                case "/":

                    if (sValue == 0)
                {
                    Console.WriteLine("НА 0 ДЕЛИТЬ НЕЛЬЗЯ!");
                }
                else
                {
                    Console.WriteLine(fValue / sValue);
                }

                Console.WriteLine(fValue / sValue);
                break;

                default:
                    Console.WriteLine("Ошибка ввода");
                break;
            

            }
            Console.ReadLine();
        }

    }
}
