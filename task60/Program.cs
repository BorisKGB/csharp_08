// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray(int firstRow, int secondRow, int thirdRow, int minVal, int maxVal)
{
    int[,,] result = new int[firstRow, secondRow, thirdRow];
    for (int i=0;i<firstRow;i++)
    {
        for (int j=0;j<secondRow;j++)
        {
            for (int l=0;l<thirdRow;l++)
            {
                result[i,j,l] = new Random().Next(minVal, maxVal+1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            for (int l=0;l<table.GetLength(2);l++)
            {
                Console.WriteLine($"{table[i, j, l]}({i}, {j}, {l})");
            }
        }
    }
}

int[,,] myArr = GenerateArray(2, 2, 2, 0, 10);
PrintArray(myArr);
