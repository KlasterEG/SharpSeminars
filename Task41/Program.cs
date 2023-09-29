// Задача 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2-> 2
// - 1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.


int[] ConvertToIntArray(string str)
{
    var stringArray = str.Split(','); // разбиваем введённую пользователем строку по запятым
    var result = new List<int>();

    foreach (var item in stringArray)
    {
        var isParsed = int.TryParse(item.Trim(), out var number); // пытаемся парсить каждое число из строки

        if (isParsed) // если получилось, добавляем в результат
        {
            result.Add(number);
        }
    }

    return result.ToArray();
}


int CalculatePositiveNumbersCount(int[] numbers) // считаем, сколько чисел в массиве больше нуля
{
    return numbers.Where(x=>x > 0).Count();
}

Console.WriteLine("Введите числа через запятую: ");
var arrayString = Console.ReadLine();

if (string.IsNullOrEmpty(arrayString))
{
    Console.WriteLine("Необходимо ввести числа через запятую");
}

var numbersArray = ConvertToIntArray(arrayString);
var count = CalculatePositiveNumbersCount(numbersArray);



// отображаем пользователю спарсенный массив и количество чисел больше нуля
Console.WriteLine("Введённый массив: [{0}]", string.Join(", ", numbersArray));
Console.WriteLine($"Количество чисел в массиве больше нуля: {count}");

