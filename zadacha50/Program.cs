// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

double GetConsole(string message)
{
    Console.WriteLine(message);
    double userNumber;
    while (true)
    {
        if(int.TryParse(Console.ReadLine(), out int number))
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
            matrix[i,j] = rndm.Next(-10, 11);
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
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindUserNumber(double[,] matrix, double number)
{
    bool result = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == number) result = true;
        }
    }
    if (result == true) Console.WriteLine($"Число {number} содержится в матрице");
    else Console.WriteLine($"Число {number} НЕ содержится в матрице");
}

double[,] matrix = InitMatrix(3,4);
PrintMatrix(matrix);
double userNumber = GetConsole("Введите число, которое хотете найти в матрице");
FindUserNumber(matrix, userNumber);
