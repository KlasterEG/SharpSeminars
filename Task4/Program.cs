// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7-> 7
// 44 5 78-> 78
// 22 3 9-> 22

Console.WriteLine("Введите первое число: ");
var firstNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
var secondNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите третье число: ");
var thirdNum = int.Parse(Console.ReadLine() ?? "0");

var numList = new List<int>
{
    firstNum,
    secondNum,
    thirdNum
};

Console.WriteLine($"Максимальное число: {numList.Max()}");


//Вариант с вводом всех чисел в одну строку
Console.WriteLine("Введите три числа через запятую:");
var inputString = Console.ReadLine();

var intArray = inputString!.Split(",").Select(x => int.Parse(x.Trim())).ToArray();
Console.WriteLine($"Максимальное число: {intArray.Max()}");