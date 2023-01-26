// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// cij​ равен сумме произведений элементов i строки матрицы A на соответствующие элементы j столбца матрицы B:
// cij=Ai1B1j+Ai2B2j+...+AinBnj
// СДЕЛАЕМ ДОПУЩЕНИЕ, ЧТО МАТРИЦЫ ОДИНАКОВЫЕ ПО РАЗМЕРУ И КВАДРАТНЫЕ
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i=0;i<result.GetLength(0);i++)
    {
        for (int j=0;j<result.GetLength(0);j++)
        {
            result[i,j] = 0;
            for (int l=0;l<result.GetLength(0);l++)
            {
                result[i,j] += matrix1[i, l] * matrix2[l,j];
            }
        }
    }
    return result;
}

int[,] firstMatrix = GenerateArray(2, 2, 0, 10);
int[,] secondMatrix = GenerateArray(2, 2, 0, 10);

Console.WriteLine("Сгенерирован матрицы");
PrintArray(firstMatrix);
Console.WriteLine("---");
PrintArray(secondMatrix);

int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Результат усножения матриц");
PrintArray(resultMatrix);
