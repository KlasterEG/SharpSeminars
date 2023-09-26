﻿// Задача 38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0, 4 9 7, 2 78]-> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. Для задачи со звездочкой использовать заполнение массива целыми числами.


double[] GenerateFloatNumberArray()
{
    var rnd = new Random();
    var begin = -100d;
    var end = 100d;
    var lenght = rnd.Next(3, 21); // задаём случайную длину массива от 3 до 20
    var result = new List<double>();

    for (int i = 0; i < lenght; i++)
    {
        // т.к. Random.NextDouble() возвращает случайное дробное число в интервале [0; 1), растягиваем этот интервал путём выполнения следующей операци 
        // Так же сразу округляем число до сотых, чтобы массив выглядел красиво
        result.Add(Math.Round(rnd.NextDouble() * (end - begin) + begin, 2)); 
    }

    return result.ToArray();
    //return new double[] { 3, 7, 22, 2, 78 };
    //return new double[] { 2, 0.4, 9, 7.2, 78 };
}

double CalculateMinMaxDifferent(double[] array)
{
    var min = array.Min(); //используем методы расширений для получения минимального и максимального значения из массива
    var max = array.Max();

    return max - min;
}


var array = GenerateFloatNumberArray(); // генерируем новый массив
var diff = CalculateMinMaxDifferent(array); // считаем разницу между максимальным и минимальным элементов массива


// отображаем пользователю массив до и после сортировки и найденные пары чисел в нём
Console.WriteLine("Сгенерирован массив: [{0}]", string.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {diff}");