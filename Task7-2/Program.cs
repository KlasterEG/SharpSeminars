using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var str = "";
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                str = str + matrix[i, j] + "\t";
            }
            Console.WriteLine(str);
        }

    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        var result = new int[n, m];
        var count = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                result[i, j] = count;
                count += k;
            }
        }

        return result;

    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition)
    {
        // Введите свое решение ниже
        var matrixRows = matrix.GetLength(0);
        var matrixColumns = matrix.GetLength(1);

        if (matrixRows <= (rowPosition - 1) || matrixColumns <= (columnPosition - 1) || rowPosition < 0 || columnPosition < 0)
        {
            return new int[] { 0, 0 };
        }

        return new int[] { matrix[rowPosition - 1, columnPosition - 1], 0 };
    }

    public static void PrintCheckIfError(int[] results, int X, int Y)
    {
        // Введите свое решение ниже
        if (results[0] == 0 && results[1] == 0) {
            Console.WriteLine("There is no such index");
        }
         else
        {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
    }


// Не удаляйте и не меняйте метод Main! 
static public void Main(string[] args)
{
    int n, m, k, x, y;

    if (args.Length >= 5)
    {
        n = int.Parse(args[0]);
        m = int.Parse(args[1]);
        k = int.Parse(args[2]);
        x = int.Parse(args[3]);
        y = int.Parse(args[4]);
    }
    else
    {
        // Здесь вы можете поменять значения для отправки кода на Выполнение
        n = 3;
        m = 4;
        k = 2;
        x = 8;
        y = 3;
    }

    // Не удаляйте строки ниже
    int[,] result = CreateIncreasingMatrix(n, m, k);
    PrintArray(result);
    PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
}
}