// Задача 66: 
// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
Console.WriteLine($"Вычисляем сумму натуральных элементов от M до N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
if (m <= n)
{
    Console.WriteLine($"Сумма натуральных элементов от {m} до {n} = {CountNaturalSum(m, n)}");
}
else
{
    Console.WriteLine($"{m} больше {n}, вычисление невозможно, перезапустите программу!");
}
