// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите строку элемента");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] array = new int[5,5];
var random = new Random();
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
void FindUserElemet(int[,] arr, int line, int column)
{
    if(line < arr.GetLength(0) && column < arr.GetLength(1))
    {
        System.Console.WriteLine($"Данный элемент есть в массиве: {arr[m,n]}");
    }
    else
    {
        System.Console.WriteLine($"Строка {m}, столбец {n} в массиве отсутствует");
    }
}
FindUserElemet(array, m, n);