using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Программа определения четности числа");
            Console.WriteLine("Введите проверяемое число: ");

            int Number = int.Parse(Console.ReadLine());

            if(Number % 2 == 0) // Остаток от деления на 2 = 0
            {
                Console.WriteLine("Число является четным");
            }
            else
            {
                Console.WriteLine("Число является нечетным");
            }

            Console.ReadKey(); // Пауза

        }
    }
}
