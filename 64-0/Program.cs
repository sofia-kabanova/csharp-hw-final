// Задача 64: Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}
int n = InputInt("Введите положительное число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число. Перезапустите программу.");
}
else
{
    Console.WriteLine($"Все натуральные числа в промежутке от {n} до 1: ");
    Console.WriteLine(NaturalNumber(n, m));
}