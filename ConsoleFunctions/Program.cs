using System;
using ClassLibrary;

namespace ConsoleFunctions
{
    /// <summary>
    /// Класс содержит метод для функционирования программы и метод выполнения функций из библиотеки.
    /// </summary>
    /// <param name="args"></param>
    class Program
    {
        /// <summary>
        /// Метод запросит параметр и вызовет методы построения последовательности и квадрата.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите параметр N.");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(OrderFunctionCall(n.ToString()));
            Console.WriteLine(SquareFunctionCall(n.ToString()));
        }
        /// <summary>
        /// Метод вызывает функцию построения последовательности чисел до параметра N из библиотеки
        /// классов ClassLibrary. Метод проверяет введенное значение на правильность.
        /// </summary>
        /// <param name="parameter"> Переменная служит для переноса вводимого значения из метода Main. </param>
        /// <returns> Метод возвращает последовательность чисел, либо сообщение об ошибке. </returns>
        public static string OrderFunctionCall(string parameter)
        {
            var result = "";
            try
            {
                var n = int.Parse(parameter);
                if (n < 1)
                {
                    result = "Для построения последовательности, число должно быть положительным и не менее 1.";
                    throw new Exception();
                }
                ComplexNumbers numbers = new ComplexNumbers();
                result = numbers.GetOrder(n);
                return result;
                
            }
            catch (Exception e)
            {
                return result;
            }
        }
        /// <summary>
        /// Метод вызывает функцию построения последовательности чисел до параметра N из библиотеки
        /// классов ClassLibrary. Метод проверяет введенное значение на правильность.
        /// </summary>
        /// <param name="parameter"> Переменная служит для переноса вводимого значения из метода Main. </param>
        /// <returns> Метод возвращает квадрат, либо сообщение об ошибке. </returns>
        public static string SquareFunctionCall(string parameter)
        {
            var result = "";
            try
            {
                var n = int.Parse(parameter);

                if (n % 2 == 0 || n < 3)
                {
                    result = "Для построения квадрата, число должно быть положительным, нечетным и не менее 3.";
                    throw new Exception();
                }
                ComplexNumbers numbers = new ComplexNumbers();
                result = numbers.GetSquare(n);
                return result;
            }
            catch (Exception e)
            {
                return result;
            }
        }
    }
}
