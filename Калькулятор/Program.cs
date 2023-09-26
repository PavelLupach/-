using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УСРС2
{
    class Program
    {
            double fValue, sValue;// лучше firstValue
            string action;
            // в методе Main не должно быть расчетов, весь функционал выносится в отдельные методы, а тут только их вызывают
        static void Main(string[] args)
        {
            GetInputData();
            Calc();                     
            Console.ReadLine();
        }

        static void Calc()
        {
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
        }
        static void GetInputData()
        {
             Console.WriteLine("Введите первое число: ");
            fValue = double.Parse(Console.ReadLine()); // следовало добавить обработку исключения на случай, если не удалось конвертировать строку в число (например ввели дробное число или буквы)

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
            action = Console.ReadLine();

            Console.WriteLine("Введите второе число: ");
            sValue = double.Parse(Console.ReadLine());

        }
            

    }
}
