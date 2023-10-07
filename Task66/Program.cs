/*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int ReadNumber(string numberStr)
{
    Console.WriteLine($"Введите число {numberStr}: ");
    return int.Parse(Console.ReadLine() ?? "0");
}


int CalculateSumm(int m, int n)
{
    var result = 0;
    for (int i = m; i <= n; i++)
    {
        result += i;
    }

    return result;
}

int m = ReadNumber("M");
int n = ReadNumber("N");

int summ = CalculateSumm(m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {summ}");