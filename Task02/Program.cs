using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Игра Blackjack
            // Правила подсчета очков взяты с Википедии
            // от двойки до десятки — от 2 до 10,
            // туз — 1 или 11 (11 пока общая сумма не больше 21, далее 1),
            // король, дама, валет — 10.

            // Объявление переменных
            int sum = 0;
            string value = "";

            Console.WriteLine("Программа для подсчета суммы карт");
            Console.Write("Введите количество карт: ");

            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\nЗаполнение номиналов карт: ");

            for (int i = 1; i <= quantity; i++)
            {
                Console.Write($"Введите номинал {i} карты: ");
                value = Console.ReadLine();

                switch (value)
                {
                    case "J": 
                    case "Q": 
                    case "K": sum += 10; break;
                    case "T":
                        if (sum + 11 > 21) sum += 1; // Если сумма больше 21, то начисляется 1                      
                        else sum += 11;
                        break;
                    default: sum += int.Parse(value); break;
                }
            }

            Console.WriteLine($"\n\nНабрано очков: {sum}");
            Console.ReadKey();

        }
    }
}
