using System;

namespace ClassLibrary
{
    public class ComplexNumbers
    {
        public void GetNumbers(int parameterN)
        {
            // Метод напишет последовательность чисел от 1 до параметра N.
            for (var i = 1; i < parameterN; i++)
            {
                Console.Write(i + ", ");
            }
            Console.Write(parameterN + ".");
            Console.WriteLine();
        }
        public void GetSquare(int parameterN)
        {
            // Если параметр N будет нечетным, метод нарисует квадрат со сторонами(N) и дыркой в центре. 
            if (parameterN % 2 != 0)
            {
                var center = parameterN / 2;
                for(var j = 0; j < parameterN; j++)
                {
                    for (var i = 0; i < parameterN; i++)
                    {
                        if (i == center && j == center)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                        
                    }
                    Console.Write('\n');
                }
                
            }
            else
            {
                Console.WriteLine("Квадрат будет построен только при нечетном параметре.");
            }
        }
    }
}
