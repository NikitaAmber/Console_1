using System;
using ClassLibrary;

namespace Consoleforpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Метод запросит параметр и выполнит 2 функции с ним. Функции из библиотеки классов ClassLibrary.
            int parameterN = 0;
            Console.WriteLine("Введите параметр N.");
            try
            {
                parameterN = int.Parse(Console.ReadLine());
                if (parameterN <= 0)
                {
                    Console.WriteLine("Вводимый параметр должен быть положительным.");
                }
                else
                {
                    ComplexNumbers Numbers = new ComplexNumbers();
                    Numbers.GetNumbers(parameterN);
                    Numbers.GetSquare(parameterN);
                }
            }
            catch
            {
                Console.WriteLine("Вводимый параметр имел неверный формат.");
            }
            
            
        }
    }
}
