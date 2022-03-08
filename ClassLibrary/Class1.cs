using System;

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
        public string GetNumbers(int n)
        {
            
            string numberOrder = "";
            for (var i = 1; i < n; i++)
            {
                numberOrder+=(i + ", ");
            }
            numberOrder += (n + ".");
            return numberOrder;
        }
        /// <summary>
        /// Если параметр N будет нечетным, метод нарисует квадрат со сторонами(N) и дырой в центре.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public string GetSquare(int n)
        {
             
            if (n % 2 == 0)
            {
                throw new Exception("Введено четное число");
            }
            string square = "";
            var center = n / 2;
            for (var j = 0; j < n; j++)
            {
                for (var i = 0; i < n; i++)
                {
                    if (i == center && j == center)
                    {
                        square += " ";
                    }
                    else
                    {
                        square += "*";
                    }

                }
                square += '\n';
            }
            return square;
        }
    }
}
