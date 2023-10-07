/*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/

int ReadNumber(string numberStr)
{
    Console.WriteLine($"Введите число {numberStr}: ");
    return int.Parse(Console.ReadLine() ?? "0");
}

int CalculateAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return CalculateAkkerman(m - 1, 1);
    }

    if (m > 0 && n > 0)
    {
        return CalculateAkkerman(m - 1, CalculateAkkerman(m, n - 1));
    }

    Console.WriteLine("Введены отрицательные числа");
    return -1;
}

var m = ReadNumber("M");
var n = ReadNumber("N");

var result =  CalculateAkkerman(m, n);
if (result > 0) { 
    Console.WriteLine($"Результат: {result}");
}
