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

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");

        var str = "";
        foreach (var item in list)
        {
            str = string.Format("{0:f2}", item);
            Console.Write($"{str}\t");
        }
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        
        var result = new List<double>();
        
        for (int i = 0; i < matrix.GetLength(1);i++)
        {
            double avr = 0d;
            for (int j = 0;j < matrix.GetLength(0);j++)
            {
                avr += Convert.ToDouble(matrix[j,i]);
            }
            avr /= matrix.GetLength(0);
            result.Add(Math.Round(avr, 2));
        }

        return result.ToArray();
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}