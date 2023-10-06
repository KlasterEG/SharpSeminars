/*
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
    01 02 03 04
    12 13 14 05
    11 16 15 06
    10 09 08 07
*/

int[,] GenerateNumberArray()
{
    var size = 4;
    int[,] result = new int[size, size];

    int pos = 0;
    int count = size;
    int value = -size;
    int sum = -1;

    do
    {
        value = -1 * value / size;

        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / size, sum % size] = pos;
            pos++;
        }

        value *= size;

        count--;

        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / size, sum % size] = pos;
            pos++;
        }

    } while (count > 0);

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

var numbersArray = GenerateNumberArray();
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbersArray);

