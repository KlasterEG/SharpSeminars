// Задача 34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// [845, 222, 367, 123-> 1
// (со звездочкой) Отсортировать массив методом пузырька

int[] GenerateNumberArray()
{
    var rnd = new Random();

    var lenght = rnd.Next(3, 21); // задаём случайную длину массива от 3 до 20
    var result = new List<int>();

    for ( int i = 0; i < lenght; i++ )
    {
        result.Add(rnd.Next(100, 1000)); //добавляем в массив случайное положительное трехзначное число
    }

    return result.ToArray();
}

int CalculateEvenNumbers(int[] numbers)
{
    var count = 0;

    foreach ( var number in numbers ) //проверяем на чётность каждое число в массиве с помощью деления на 2 без остатка
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int[] BubbleSort(int[] array) // сортировка массива методом пузырька
{
    /*
     *  создаём новый массив и копируем в него сгенерированный массив через метод Array.Copy,
     *  иначе при простом присвоении будет присвоена ссылка на первый массив и все манипуляции с сортировкой 
     *  будут сделаны в сгенерированном массиве. В итоге получим два одинаковых массива (вернее один массив с двумя ссылками на него) в конце
     *  */

    var sortArray = new int[array.Length];
    Array.Copy(array, sortArray, array.Length); 
   
    
    var len = sortArray.Length;
    for (var i = 1; i < len; i++)
    {
        for (var j = 0; j < len - i; j++)
        {
            if (sortArray[j] > sortArray[j + 1])
            {
                (sortArray[j + 1], sortArray[j]) = (sortArray[j], sortArray[j + 1]); // меняем местами значения элементов с помощью кортежа
            }
        }
    }

    return sortArray;
}


var array = GenerateNumberArray(); // генерируем новый массив
var evenNumbersCount = CalculateEvenNumbers(array); // считаем количество чётных чисел
var sortedArray = BubbleSort(array);


// отображаем пользователю массив до и после сортировки и количество чётных чисел в нём
Console.WriteLine("Сгенерирован массив: [{0}]", string.Join(", ", array));
Console.WriteLine("Сортированный массив [{0}]", string.Join(", ", sortedArray));
Console.WriteLine($"Количество чётных чисел в массиве: {evenNumbersCount}");