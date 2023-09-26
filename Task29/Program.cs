// Задача 29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов
// 
// (задание со *) Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал
// Игорь, Антон, Сергей -> Антон
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1). 


Console.WriteLine("Введите длину массива: ");
var arrayLenght = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите минимум диапазона чисел в массиве: ");
var arrayMin = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите максимум диапазона чисел в массиве: ");
var arrayMax = int.Parse(Console.ReadLine() ?? "0");

int[] GenerateArray(int lenght, int min, int max)
{
    if (lenght < 1)
    {
        lenght = 8; // ставим дефолтное значение длины массива если ввели число меньше 1 или не число и после парсинга пришёл 0
    }

    if (max == 0)
    {
        max = 100; //  ставим дефолтное значение максимума чисел в массиве если ввели число меньше 1 или не число и после парсинга пришёл 0
    }


    var result = new List<int>();
    Random rnd = new Random();

    for (int i = 0; i < lenght; i++)
    {
        result.Add(rnd.Next(min, max + 1));
    }

    return result.ToArray();
}

Console.WriteLine("Сгенерированный массив: [{0}]", string.Join(", ", GenerateArray(arrayLenght, arrayMin, arrayMax)));