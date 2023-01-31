/* Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine()!);
            
            void NumberCounter(int N)
            {
                if (N < 0) Console.Write($"{N} не натуральное число");
                if (N == 0) return;
                Console.Write("{0,4}", N);
                NumberCounter(N - 1);
            }
            
            NumberCounter(N); 
