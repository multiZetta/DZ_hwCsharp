/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


Console.Write("Введите количество строк. ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов. ");
int n = Convert.ToInt32(Console.ReadLine());


//Cоздание двумерного массива.
int[,] matrix = new int[m, n];

// Заполнение двумерного массива рамдомно до 10.

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
}

//Печать массива

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
}
PrintArray(matrix);
Console.WriteLine("");


// РЕШЕНИЕ задачи


void SelectionSort(int[,] matrix)
{
    int max = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, k - 1])
                {
                    max = matrix[i, k - 1];
                    matrix[i, k - 1] = matrix[i, k];
                    matrix[i, k] = max;
                }
            }
        }
    }
}
SelectionSort(matrix);

PrintArray(matrix);         // печать массива с исполненной задачей
