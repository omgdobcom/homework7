// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[m, n];

FillArray(array);
Print(array);
int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
    return arr;
}
void Print(int[,] arr)
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

void FindeAverge(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sumAverge =0;
    
        for (int i = 0; i < arr.GetLength(0); i++)
            {
            sumAverge += arr[i,j];
            }
        double result = Math.Round(sumAverge / arr.GetLength(0), 2);
        System.Console.WriteLine($"Среднее арифмитическое столбца {j + 1}: {result}");
    }
}
FindeAverge(array);