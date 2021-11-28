using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует калькулятор!");
            int x, y, a;

            Console.WriteLine();
            try
            {
                Console.Write("Введите целое число. Х = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Введите код операции:\n 1 - сумма;\n 2 - разность;\n 3 - произведение;\n 4 - частное;");
                Console.WriteLine("Ваш выбор: ");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Console.WriteLine("Сумма равна = {0}", (x + y));
                }
                else if (a == 2)
                {
                    Console.WriteLine("Разность равна = {0}", (x - y));
                }
                else if (a == 3)
                {
                    Console.WriteLine("Произведение равно = {0}", (x * y));
                }
                else if (a == 4)
                {
                    Console.WriteLine("Частное равно = {0}", (x / y));
                }
                else
                {
                    Console.WriteLine("Нет операции с указанным номером!");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка! {0} ", ex.Message);

            }
            Console.ReadKey();

        }
    }
}
