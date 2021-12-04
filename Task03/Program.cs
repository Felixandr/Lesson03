using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация переменных 
            int i = 2;              // Проверка начинается с 2
            bool result = true;     // По умолчанию считается, что число простое
            int number = 0;

            Console.WriteLine("Программа проверки простого числа\n");
            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());

            while(i < number)
            {
                if(number % i == 0)
                {
                    result = false;
                    break; // Выходим из цикла, т.к. число уже не является простым и дальнейшая обработка не требуется
                }

                i++;
            }

            if (result)
            {
                Console.WriteLine($"\nЧисло {number} является простым");                
            }
            else
            {
                Console.WriteLine($"\nЧисло {number} не является простым");
            }

            Console.ReadKey();

        }
    }
}
