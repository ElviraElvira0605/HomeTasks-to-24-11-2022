// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
//  Выполнить с помощью рекурсии.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30 

using System;

class Program
{
    // Печать чисел от M до N
    static int SumNumbers(int M, int N)
    {
        // Если M равно N
        if (M == N)
            // Сумма равна M (или N, т.к. они равны)
            return M;
        // Иначе сумма от M до N равна
        // сумме M и суммы от M + 1 до N
        return M + SumNumbers(M + 1, N);
    }

    // Основная программа
    static void Main()
    {
        // Рандомизатор
        Random r = new Random();
        // Создание числа M
        int M = r.Next(5, 21);
        // Создание числа N
        int N = r.Next(M, M + 16);
        // Вывод результата
        Console.Write($"M = {M}; N = {N} -> {SumNumbers(M, N)}");
    }
}


