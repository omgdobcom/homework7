// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. m = 3, n = 4.

System.Console.WriteLine("Создан рандомынй двумерный массив");

Console.WriteLine();
double[,] array = new double[3, 4];
var random = new Random();

FillArray(array, -11.1, 11.1);
Print(array);
double[,] FillArray(double[,] arr, double min, double max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(random.NextDouble() * (max - min) + min,2);
        }
    }
    return arr;
}
void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}