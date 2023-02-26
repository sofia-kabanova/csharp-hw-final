// Задача 68:
// Напишите программу
// вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
void Note1(string note1)
{
    Console.WriteLine(note1);
}
void Note2(string note2)
{
    Console.WriteLine(note2);
}
Console.WriteLine("Вычисляем функцию Аккермана.");
Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
string note1 = ("Вы ввели отрицательное число, перезапустите программу!");
string note2 = ("Вы ввели отрицательные числа, перезапустите программу!");
if (m < 0 & n >= 0) Note1(note1);
else if (m >= 0 & n < 0) Note1(note1);
else if (m < 0 & n < 0) Note2(note2);
else
{
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
}