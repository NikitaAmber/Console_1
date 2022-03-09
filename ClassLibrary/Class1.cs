using System;
using System.Text;
namespace ClassLibrary
{
    /// <summary>
    /// Класс содержит методы написания последовательности до N
    /// и построения квадрата со сторонами N с дырой в центре;
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public class ComplexNumbers
    {

        /// <summary>
        /// Метод напишет последовательность чисел от 1 до параметра N. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string GetOrder(int n)
        {
            if (n < 1)
            {
                var error = "Для построения последовательности, число должно быть положительным и не менее 1.";
                throw new Exception();
                return error;
            }
            var numberOrder = new StringBuilder();
            for (var i = 1; i < n; i++)
            {
                numberOrder.Append(i + ", ");
            }
            numberOrder.Append(n + ".");
            return numberOrder.ToString();
        }

        /// <summary>
        /// Если параметр N будет нечетным, метод нарисует квадрат со сторонами(N) и дырой в центре.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string GetSquare(int n,char squareSymbol ='*')
        {
            if (n % 2 == 0 || n < 3)
            {
                var error = "Для построения квадрата, число должно быть положительным, нечетным и не менее 3.";
                throw new Exception();
                return error;
            }
            var square = new StringBuilder();
            var center = n / 2;
            for (var j = 0; j < n; j++)
            {
                for (var i = 0; i < n; i++)
                {
                    square.Append(i == center && j == center
                        ? " "
                        : squareSymbol.ToString());
                }
                square.Append('\n');
            }
            return square.ToString();
        }
    }
}
