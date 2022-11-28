// Задача 68: Напишите программу вычисления функции
//  Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// Например:
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

class Program
{
    // Нахождение значения функции Аккермана
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (n == 0)
            return Ackermann(m - 1, 1);
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    // Основная программа
    static void Main()
    {
        // Рандомизатор
        Random r = new Random();
        // Создание числа m
        int m = r.Next(0, 4);
        // Создание числа n
        int n = r.Next(0, 10);
        // Вывод результата
        Console.Write($"m = {m}; n = {n} -> {Ackermann(m, n)}");
    }
}


