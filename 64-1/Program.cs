﻿// Задача 64: Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.WriteLine("Вы ввели не положительное число.");
}
Console.WriteLine(NaturalNumber(n, m));
int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}


