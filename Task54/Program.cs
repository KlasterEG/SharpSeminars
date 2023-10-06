/*
    Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    В итоге получается вот такой массив:
    7 4 2 1
    9 5 3 2
    8 4 4 2
*/

int[,] GenerateNumberArray()
{
    var rnd = new Random();
    var x = rnd.Next(4, 10); //генерируем случайный размер массива
    var y = rnd.Next(4, 10);

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

int[,] SortNumbersInArray(int[,] numbers)
{
    /*
    *  создаём новый массив и копируем в него сгенерированный массив через метод Array.Copy,
    *  иначе при простом присвоении будет присвоена ссылка на первый массив и все манипуляции с сортировкой 
    *  будут сделаны в сгенерированном массиве. В итоге получим два одинаковых массива (вернее один массив с двумя ссылками на него) в конце
    *  */

    var result = new int[numbers.GetLength(0), numbers.GetLength(1)];
    Array.Copy(numbers, result, numbers.Length);

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        var sortArray = new List<int>();
        for (int j = 0;j < numbers.GetLength(1); j++) //собираем из строки новый одномерный массив
        {
            sortArray.Add(numbers[i, j]);
        }

        sortArray = sortArray.Order().ToList(); // сортируем массив

        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            result[i, j] = sortArray[j]; // складываем сортированные значения в результат
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

var sortedArray = SortNumbersInArray(array);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);
Console.WriteLine("Сортированный массив:");
PrintArray(sortedArray);