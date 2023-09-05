// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Console.Clear();

int[,] Get2DArray(int cols, int rows, int deviation)
{
    int[,] array = new int[cols, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(0, deviation);
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] DoubleEven2DArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int[,] result = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) result[i, j] = array[i, j] * array[i, j];
            else result[i, j] = array[i, j];
        }
    }
    return result;
}

int[,] arr = Get2DArray(5, 5, 10);
Print2DArray(arr);
int[,] newArr = DoubleEven2DArray(arr);
Print2DArray(newArr);