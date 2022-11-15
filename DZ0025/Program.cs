/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/* int row = 4;
int column = 4;

Console.WriteLine($"Матрица {row}*{column}");

int[,] matrix = new int[row, column];


int pos = 1;
int count = column;
int value = -column;
int sum = -1;

while (count > 0)
{
    value = -1 * value / column;
    for (int i = 0; i < count; i++)
    {
        sum += value;
        matrix[sum / column, sum % column] = pos++;
    }
    value *= column;
    count--;
    for (int i = 0; i < count; i++)
    {
        sum += value;
        matrix[sum / column, sum % column] = pos++;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.Write($"{array[i, j],4}");       // 4 позволяет печатать ровнее по правому краю. Можно любую цифру см. по печати
        }
        Console.WriteLine();
    }
}
PrintArray(matrix); */