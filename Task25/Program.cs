// Задача 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5-> 243(3⁵)
// 2, 4-> 16
// (задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень 

Console.WriteLine("Введите число: ");
var inputNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите степень: ");
var degreeNum = int.Parse(Console.ReadLine() ?? "0");

int Calculate(int number, int degree)
{
    var result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

bool ValidateInput(int number, int degree)
{
    if (number < 0)
    {
        Console.WriteLine("Число меньше нуля");
        return false;
    }

    if (degree < 0)
    {
        Console.WriteLine("Степень меньше нуля");
        return false;
    }
    return true;
}

if (ValidateInput(inputNum, degreeNum)){
    Console.WriteLine($"Число {inputNum} в степени {degreeNum} равно {Calculate(inputNum, degreeNum)}");
}