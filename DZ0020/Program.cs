/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/


// Создали двумерный массив случайных чисел от 1 до 1000. 
// С заданным от пользователя размером массива

//Условия для пользователя ввода с клавиатуры

//Console.WriteLine("Двумерный массив будет заполнен рандомными числами до 1000 ");

Console.Write("Введите количество строк. ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов. ");
int n = Convert.ToInt32(Console.ReadLine());


//Cоздание двумерного массива.
int[,] matrix = new int[m, n];
matrix = FillArray(matrix);


// Заполнение двумерного массива.
int[,] FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

//Печать массива
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++, Console.WriteLine(""))
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
}
PrintArray(matrix);

// РЕШЕНИЕ задачи

Console.Write("Среднее арифметическое каждого столбца: ");

void SummArrayСolumnsArm(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        sum = Math.Round((sum / matrix.GetLength(0)), 2);
        Console.Write(+sum + "; ");
    }
}
SummArrayСolumnsArm(matrix);

