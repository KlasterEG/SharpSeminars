/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/

int[,] GenerateNumberArray(int x, int y) //делаем генератор массивов с входными параметрами т.к. нужно генерировать матрицы одинакового размера
{
    var rnd = new Random();

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

int[,] CalculateMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    var result = new int[matrix1.GetLength(1), matrix2.GetLength(0)]; //Произведение двух матриц выполнимо только в случае, если количество столбцов первой матрицы равно количеству строк второй.

    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = 0;

            for (var k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
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

var matrix1 = GenerateNumberArray(3, 3);
var matrix2 = GenerateNumberArray(3, 3);
var result = CalculateMatrixMultiplication(matrix1, matrix2);

Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);

Console.WriteLine("Результат произведения:");
PrintArray(result);