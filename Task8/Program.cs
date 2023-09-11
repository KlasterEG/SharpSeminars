// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5-> 2, 4
// 8-> 2, 4, 6, 8

Console.WriteLine("Эта программа показывает все чётные числа от 1 до введённого числа.");
Console.WriteLine("Введите число больше 1:");
var inputNum = int.Parse(Console.ReadLine() ?? "0");

if (inputNum < 2)
{
    Console.WriteLine("Вы ввели число меньше 1");
}else if (inputNum < 4)
{
    Console.WriteLine(2);
}
else
{
    Console.Write(2);
    for (int i = 4; i <= inputNum; i += 2)
    {
        Console.Write($", {i}");
    }
}