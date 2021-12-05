using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!

            int userTry = 4;            // Максимально число выбираемое пользователем
            int gameNumber = 0;         // Игровое число
            int gameNumberStart = 12;   // Начальный Диапазон
            int gameNumberEnd = 120;    // Окончание диапазона       
            int thisGame = 1;           // Тип в меню            
            int tmp = 0;                // Выбираемое пользователем значение

            // Игроки, так как массивы еще не изучены, то ограничимся 6
            int thisPlayer = 1;         // Текущий игрок
            string thisPlayerName = ""; 
            int quantityPlayer = 2;
            string playerName1 = "";
            string playerName2 = "";
            string playerName3 = "";
            string playerName4 = "";
            string playerName5 = "";
            string playerName6 = "";

            while (true)
            {
                // Главное меню
                if (thisGame == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Главное меню:\n");
                    Console.WriteLine("1 - Играть с ИИ");
                    Console.WriteLine("2 - Играть против людей");
                    Console.WriteLine("3 - Настройка сложности");
                    Console.WriteLine("0 - Выйти");

                    tmp = int.Parse(Console.ReadLine());
                    if(tmp == 0)
                    {
                        break;
                    }
                    else
                    {
                        thisGame = tmp + 1; // 1 - это само Меню, поэтому увеличиваем на 1
                    }

                }
                // Игра с ИИ
                else if (thisGame == 2)
                {
                    Console.Clear(); 
                    Console.WriteLine("Игра с ИИ:\n");
                    Console.Write("Введите свой ник: ");
                    playerName1 = Console.ReadLine();

                    Random rand = new Random();
                    // Выбираем ник боту
                    tmp = rand.Next(1, 6);
                    switch (tmp)
                    {
                        case 1: playerName2 = "ИИ"; break;
                        case 2: playerName2 = "Алиса"; break;
                        case 3: playerName2 = "Себастьян"; break;
                        case 4: playerName2 = "Му-му"; break;
                        case 5: playerName2 = "Иван Васильевич"; break;
                        case 6: playerName2 = "Чебурашка"; break;
                    }
                    // Выбираем число
                    gameNumber = rand.Next(gameNumberStart, gameNumberEnd + 1);

                    while (gameNumber > 0)
                    {

                        switch (thisPlayer)
                        {
                            case 1: thisPlayerName = playerName1; break;
                            case 2: thisPlayerName = playerName2; break;
                            default: break;
                        }
                        Console.WriteLine($"\nХодит игрок {thisPlayerName}. Текущее значение: {gameNumber}");
                        if (thisPlayer == 1)
                        {
                            Console.Write($"Введите число от 1 до {userTry}: ");
                            tmp = int.Parse(Console.ReadLine());
                            if (tmp < 1 || tmp > userTry)
                            {
                                Console.WriteLine("Введите значение из диапазона!");
                            }
                            else
                            {
                                gameNumber = gameNumber - tmp;

                                if (gameNumber > 0)
                                {
                                    thisPlayer = 2; //Далее ходит бот
                                }
                            }
                        }
                        else
                        {
                            //Описываем логику бота
                            if (gameNumber <= userTry) tmp = gameNumber; // Выставляем оставшееся                           
                            else if (gameNumber - userTry <= userTry)
                            {
                                tmp = gameNumber - userTry - 1; // Оставляет userTry + 1 в gameNumber чтобы игрок не мог закончить игру
                                if (tmp < 1 || tmp > userTry) tmp = rand.Next(1, userTry + 1); // Число может оказаться вне диапазона если игрок переиграл бота.
                            }
                            else tmp = rand.Next(1, userTry + 1); // Любое рандомное число в диапазоне
                          
                            Console.WriteLine($"Введите число от 1 до {userTry}: {tmp}");

                            gameNumber = gameNumber - tmp;

                            if (gameNumber > 0)
                            {
                                thisPlayer = 1; //Далее ходит бот
                            }

                        }
                    }

                    // Победа
                    Console.Clear();
                    Console.WriteLine($"Поздравляю с победой {thisPlayerName}! Еще одна игра?");
                    Console.WriteLine("1 - Играть");
                    Console.WriteLine("0 - Выйти в меню");
                    tmp = int.Parse(Console.ReadLine());
                    if (tmp == 1)
                    {
                        thisGame = 2;
                    }
                    else
                    {
                        thisGame = 1;
                    }

                }

                // Игра с людьми
                else if (thisGame == 3) 
                {
                    Console.Clear(); 
                    Console.WriteLine("Игра с людьми:\n");
                    Console.WriteLine("Выберите количество игроков от 2 до 6");
                    Console.WriteLine("0 - Назад");
                    tmp = int.Parse(Console.ReadLine());

                    if(tmp == 0)
                    {
                        thisGame = 1; // в Главное меню
                    }
                    else if(tmp < 2 || tmp > 6)
                    {
                        Console.WriteLine("Введите значение в диапазоне!");
                        Console.ReadKey();
                    }
                    else {
                        quantityPlayer = tmp;

                        Console.Clear();
                        Console.WriteLine("Игра с людьми:\n"); 
                        Console.WriteLine("Введите ники игроков:\n");
                        // Первые 2 игрока есть всегда!
                        Console.Write("Введите ник 1 игрока: ");
                        playerName1 = Console.ReadLine();                   
                        Console.Write("Введите ник 2 игрока: ");
                        playerName2 = Console.ReadLine();
                        // Перебираем остальных игроков, пока нет массивов делаем некрасиво
                        // Игрок 3
                        if(quantityPlayer >= 3)
                        {
                            Console.Write("Введите ник 3 игрока: ");
                            playerName3 = Console.ReadLine();
                        }
                        // Игрок 4
                        if (quantityPlayer >= 4)
                        {
                            Console.Write("Введите ник 4 игрока: ");
                            playerName4 = Console.ReadLine();
                        }
                        // Игрок 5
                        if (quantityPlayer >= 5)
                        {
                            Console.Write("Введите ник 5 игрока: ");
                            playerName5 = Console.ReadLine();
                        }
                        // Игрок 6
                        if (quantityPlayer >= 6)
                        {
                            Console.Write("Введите ник 6 игрока: ");
                            playerName6 = Console.ReadLine();
                        }

                        // Выбираем число
                        Random rand = new Random();
                        gameNumber = rand.Next(gameNumberStart, gameNumberEnd + 1);
                        thisPlayer = 1; // ходит первый
                        

                        //Игра
                        Console.Clear();
                        Console.WriteLine("Игра с людьми:\n");
                        while (gameNumber > 0)
                        {
                            
                            switch (thisPlayer)
                            {
                                case 1: thisPlayerName = playerName1; break;
                                case 2: thisPlayerName = playerName2; break;
                                case 3: thisPlayerName = playerName3; break;
                                case 4: thisPlayerName = playerName4; break;
                                case 5: thisPlayerName = playerName5; break;
                                case 6: thisPlayerName = playerName6; break;
                                default: break; 
                            }
                            Console.WriteLine($"\nХодит игрок {thisPlayerName}. Текущее значение: {gameNumber}");
                            Console.Write($"Введите число от 1 до {userTry}: ");
                            tmp = int.Parse(Console.ReadLine());
                            if(tmp < 1 || tmp > userTry)
                            {
                                Console.WriteLine("Введите значение из диапазона!");
                            }
                            else
                            {
                                gameNumber = gameNumber - tmp;

                                if(gameNumber > 0)
                                {
                                    if (thisPlayer == quantityPlayer) thisPlayer = 1; // возвращаемся к 1 игроку
                                    else thisPlayer = thisPlayer + 1; // Ход следующего игрока
                                }
                            }
                        }

                        // Победа
                        Console.Clear();
                        Console.WriteLine($"Поздравляю с победой {thisPlayerName}! Еще одна игра?");
                        Console.WriteLine("1 - Играть");
                        Console.WriteLine("0 - Выйти в меню");
                        tmp = int.Parse(Console.ReadLine());
                        if(tmp == 1)
                        {
                            thisGame = 3;
                        }
                        else
                        {
                            thisGame = 1;
                        }
                    }

                }
                // Настройка
                else if (thisGame == 4) 
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Настройка:\n");
                        Console.WriteLine($"1 - Изменить диапазон загаданного числа (тек: {gameNumberStart}-{gameNumberEnd})");
                        Console.WriteLine($"2 - Изменить диапазон чисел для угадывания (тек: 1-{userTry})");
                        Console.WriteLine("0 - Назад");

                        tmp = int.Parse(Console.ReadLine());
                        if (tmp == 0)
                        {
                            thisGame = 1;
                            break;
                        }
                        else if (tmp == 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Изменение диапазона загаданного числа текущее: {gameNumberStart}-{gameNumberEnd})");
                            Console.Write("Введите начальное число: ");
                            gameNumberStart = int.Parse(Console.ReadLine());
                            Console.Write("Введите конечное число: ");
                            gameNumberEnd = int.Parse(Console.ReadLine());
                        }
                        else if (tmp == 2)
                        {
                            Console.Clear(); 
                            Console.WriteLine($"Изменение диапазона чисел для угадывания текущее: 1-{userTry})");
                            Console.Write("Введите максимальное число: ");
                            userTry = int.Parse(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    break;
                }

            }
        }
    }
}
