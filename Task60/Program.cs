/*
    Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

int[,,] GenerateNumberArray(int x, int y, int z) //делаем генератор массивов с входными параметрами
{
    var rnd = new Random();
    var result = new int[x, y, z];
    var usedNumbers = new List<int>(); // добавляем список использованных чисел, чтобы генерировать массив не повторяющихся чисел

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (var k = 0; k < z; k++)
            {
                var added = false;
                while (!added)
                {
                    var number = rnd.Next(10, 100);
                    if (!usedNumbers.Contains(number))
                    {
                        result[i, j, k] = number;
                        usedNumbers.Add(number);
                        added = true;
                    }
                }
            }
        }
    }

    return result;
}


void PrintArray(int[,,] numbers)
{
    for (int k = 0; k < numbers.GetLength(2); k++) // первый цикл делаем по третьему измерению, чтобы получить ответ как в условии задачи
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (var j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write($"{numbers[i, j, k]}({i}, {j}, {k}) \t");
            }
            Console.WriteLine();
        }
    }
}

var numberArray = GenerateNumberArray(2,2,2);

Console.WriteLine($"Сгенерирован массив {numberArray.GetLength(0)} x {numberArray.GetLength(1)} x {numberArray.GetLength(2)}:");
PrintArray(numberArray);