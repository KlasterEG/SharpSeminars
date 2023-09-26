// Задача 36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1]-> 8
// [-4, -6, 89, 6]-> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю


int[] GenerateNumberArray()
{
    var rnd = new Random();

    var lenght = rnd.Next(3, 21); // задаём случайную длину массива от 3 до 20
    var result = new List<int>();

    for (int i = 0; i < lenght; i++)
    {
        result.Add(rnd.Next(-100, 101)); //добавляем в массив случайные числа от -100 до 100
    }

    return result.ToArray();
    //return new int[] { -1, 2, 1, 4, 6, -7, 12, -2, 3 }; //для удобства проверки тут можно подставить нужный массив, а строку выше закомментировать
}

int CalculateOddElementSumm(int[] array)
{
    var result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }

    return result;
}

int[][] FindNumberPairs(int[] array) // будем искать пары противоположных чисел, например -5 и 5
{
    var result = new List<List<int>>();

    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j ++)
        {
            if (array[j] + array[i] == 0)
            {
                result.Add(new List<int>() { array[i], array[j] });
            }
        }
    }

    return result.Select(x=>x.ToArray()).ToArray();
}

var array = GenerateNumberArray(); // генерируем новый массив
var summ = CalculateOddElementSumm(array); // считаем сумму нечётных элементов
var numberPairs = FindNumberPairs(array); // ищем пары чисел


// отображаем пользователю массив до и после сортировки и найденные пары чисел в нём
Console.WriteLine("Сгенерирован массив: [{0}]", string.Join(", ", array));
Console.WriteLine($"Сумма нечётных чисел в массиве: {summ}");

if (numberPairs.Length == 0)
{
    Console.WriteLine("Пары чисел не найдены");
} else
{
    Console.WriteLine("Пары чисел в массиве: [{0}]", string.Join("], [", numberPairs.Select(x=> string.Join(", ", x)).ToArray()));
}