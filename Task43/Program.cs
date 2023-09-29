// Задача 43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; 5,5)
// (Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых


Console.WriteLine("Введите координаты прямых.");
Console.WriteLine("Введите k1:");
var k1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b1:");
var b1 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите k2:");
var k2 = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b2:");
var b2 = double.Parse(Console.ReadLine() ?? "0");

bool ValidateLineCoordinates(double k1, double b1, double k2, double b2) // проверяем прямые на пересечение
{
    if (k1 == k2)
    {
        if (b1 == b2) // если все координаты совпадают, то прямые тоже совпадают
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
         else // если координаты k совпадают, то прямые параллельны и никогда не пересекутся
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}


double[] FindCoordinates(double k1, double b1, double k2, double b2)
{
    var result = new double[2];
    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * result[0] + k1;
    return result;
}

if (ValidateLineCoordinates(k1, b1, k2, b2))
{
    var coordinates = FindCoordinates(k1, b1, k2, b2);
    Console.Write($"Точка пересечения уравнений y={k1}*x+{b1} и y={k2}*x+{b2} имеет координаты ({coordinates[0]};{coordinates[1]})");
}