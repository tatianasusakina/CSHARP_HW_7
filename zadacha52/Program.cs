// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int GetConsole(string message)
{
    Console.WriteLine(message);
    int userNumber;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;
        }
        else Console.WriteLine("Вы ввели не число");
    }
    return userNumber;
}

double[,] InitMatrix(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    Random rndm = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rndm.Next(0, 9);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetAverage(double[,] matrix)
{
    // double[] average = new double[matrix.GetLength(1)];
    // double[] summ = new double[matrix.GetLength(0)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summ += matrix[i, j];
        }
        Console.Write(Math.Round(summ / matrix.GetLength(0), 2) + " ");
    }
}


int rows = GetConsole("Введите количество строк");
int columns = GetConsole("Введите количество столбцов");
double[,] matrix = InitMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine();
GetAverage(matrix);

