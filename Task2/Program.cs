// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.WriteLine("Введите первое число: ");
var firstNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
var secondNum = int.Parse(Console.ReadLine() ?? "0");

if (firstNum > secondNum)
{
    Console.WriteLine($"Первое число {firstNum} больше второго числа {secondNum}");
} else if (firstNum < secondNum)
{
    Console.WriteLine($"Второе число {secondNum} больше первого числа {firstNum}");
} else
{
    Console.WriteLine($"Введенные числа равны");
}