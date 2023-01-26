// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArrayRows(int[,] table)
{
    int minPosition, tmpVal;
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            minPosition = j;
            for (int k=j+1;k<table.GetLength(1);k++)
            {
                if (table[i,k] > table[i, minPosition])
                {
                    tmpVal = table[i,j];
                    table[i,j] = table[i, k];
                    table[i, k] = tmpVal;
                }
            }
        }
    }
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
SortArrayRows(myArr);
Console.WriteLine("После сортировки по строкам массив выглядит");
PrintArray(myArr);
