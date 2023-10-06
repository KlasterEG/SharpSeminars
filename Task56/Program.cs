/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenerateNumberArray()
{
    var rnd = new Random();
    var x = rnd.Next(4, 10); //генерируем случайный размер массива
    var y = x + rnd.Next(1, 4); //делаем массив прямоугольным

    var result = new int[x, y];

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            result[i, j] = rnd.Next(0, 10); //генерируем случайное наполнение массива
        }
    }

    return result;
}

int CalculateLowestRowSumm(int[,] numbers)
{
    var result = 1;
    var lowestSumm = int.MaxValue;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        var summ = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            summ += numbers[i, j];
        }

        if (summ < lowestSumm) { 
            lowestSumm = summ;
            result = i;
        }
    }

    return result;
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        var str = "";
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            str = str + numbers[i, j] + "\t";
        }
        Console.WriteLine(str.Trim());
    }
}

var array = GenerateNumberArray();
var rowNumber = CalculateLowestRowSumm(array);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);
Console.WriteLine($"Наименьшая сумма элементов на строке {rowNumber}");
