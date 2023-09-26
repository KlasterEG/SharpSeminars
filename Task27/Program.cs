// Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452-> 11
// 82-> 10
// 9012-> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки 

Console.WriteLine("Введите число: ");
var inputNum = int.Parse(Console.ReadLine() ?? "0");

int CalculateSumm(int number)
{
    var result = 0;

    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}

Console.WriteLine($"Сумма цифр в числе {inputNum} равна {CalculateSumm(inputNum)}");