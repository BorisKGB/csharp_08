// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CountRowElementsSum(int[,] table, int row)
{
    int result = 0;
    for (int i=0;i<table.GetLength(1);i++)
    {
        result += table[row, i];
    }
    return result;
}

int GetNumberOfrowWithMinElementsSum(int[,] table)
{
    int min = 0;
    for (int i=0;i<table.GetLength(0);i++)
    {
        if (CountRowElementsSum(table, i) < CountRowElementsSum(table, min)) min = i;
    }
    return min;
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
Console.WriteLine($"Номер строки с минимальной суммой элементов {GetNumberOfrowWithMinElementsSum(myArr)}(При счёте с ноля)");
