/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int ReadNumber()
{
    Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine() ?? "0");
}


void GenLineRec(int number)
{
    Console.Write(number); //выводим число на экран
    if (number <= 1)
    {
    }
    else
    {
        Console.Write(", "); // добавляем запятую, т.к. будет ещё одно число
        GenLineRec(number - 1);
    }
}

int number = ReadNumber();
GenLineRec(number);