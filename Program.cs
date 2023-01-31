/* Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/*Console.Write("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine()!);
            
            void NumberCounter(int N)
            {
                if (N < 0) Console.Write($"{N} не натуральное число");
                if (N == 0) return;
                Console.Write("{0,4}", N);
                NumberCounter(N - 1);
            }
            
            NumberCounter(N); */


/*Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке
 от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */

/*Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine()!);

void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);*/

/*Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

Console.WriteLine("Введите число M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);

int Akkerman(int M, int N)
{
  if (M == 0) return N + 1;
  else if (N == 0) return Akkerman(M - 1, 1);
  else return Akkerman(M - 1, Akkerman(M, N - 1));
}

int function = Akkerman(M, N);
Console.Write($"A(M,N) = {function} ");