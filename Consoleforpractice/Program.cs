using System;
using ClassLibrary;

namespace Consoleforpractice
{
    /// <summary>
    /// Класс содержит основную функцию для функционирования программы.
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        /// <summary>
        /// Метод запросит параметр и выполнит 2 функции с ним. Функции из библиотеки классов ClassLibrary.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите параметр N.");
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    throw new Exception("Число должно быть положительным и не менее 1");
                }
                    ComplexNumbers numbers = new ComplexNumbers();
                    Console.WriteLine(numbers.GetNumbers(n));
                    Console.WriteLine();
                    Console.WriteLine(numbers.GetSquare(n));
            }
            catch (Exception e)
            {
                Console.WriteLine("Вводимый параметр не подходит для выполнения функции.");
            }
        }
    }
}
