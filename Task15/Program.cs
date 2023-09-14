// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// * Сделать вариант с использованием конструкции Dictionary

Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
var inputNum = int.Parse(Console.ReadLine() ?? "0");

if (inputNum < 1 || inputNum > 7) //проверяем что пользователь ввёл корректный номер дня недели
{
    Console.WriteLine("Необходимо ввести цифру дня недели от 1 до 7");
} 
else
{
    switch (inputNum) //используем конструкицю switch чтобы вывести правильный ответ
    {
        case 1: 
            Console.WriteLine("Нет");
            break; 
        case 2: 
            Console.WriteLine("Нет");
            break;
        case 3: 
            Console.WriteLine("Нет");
            break;
        case 4: 
            Console.WriteLine("Нет");
            break;
        case 5: 
            Console.WriteLine("Нет");
            break;
        case 6: 
            Console.WriteLine("Да");
            break;
        case 7: 
            Console.WriteLine("Да");
            break;
        default: 
            Console.WriteLine("Нет");
            break;
    }
}

/*вариант со словарём*/
Console.WriteLine("Введите цифру дня недели от 1 до 7: ");
var inputNumber = int.Parse(Console.ReadLine() ?? "0");

var weekDaysDictionary = new Dictionary<int, string>() //создаём словарь соответствий
{
    {1, "Нет" },
    {2, "Нет" },
    {3, "Нет" },
    {4, "Нет" },
    {5, "Нет" },
    {6, "Да" },
    {7, "Да" }
};

if (inputNumber < 1 || inputNumber > 7)
{
    Console.WriteLine("Необходимо ввести цифру дня недели от 1 до 7");
}
else
{
    Console.WriteLine(weekDaysDictionary[inputNumber]); //берём значение из словаря по ключу и показываем в консоль
}