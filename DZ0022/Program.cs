/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */


Console.Write("Введите количество строк. ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов. ");
int n = Convert.ToInt32(Console.ReadLine());

int[] SumArray = new int[m];     // Создание одномерного массива из результатов сумм в строках

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


//Console.WriteLine("Сумма элементов по строкам: ");

void SummArrayRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        SumArray[i] = sum;                                    // сумма под номером строки
        Console.WriteLine($"В строке {i} сумма элементов составляет {SumArray[i]}");
    }
}
SummArrayRows(matrix);

// Количество ответов. Этот шаг можно и не делать в этой задаче

int count = 0;
for (int i = 0; i < m; i++)
{
    count++;
}
Console.WriteLine("Количество ответов " + count);

// Делаем сравнение строк "i" из результатов по суммам

int minSum = SumArray[0];                       // пусть минимальное значение будет в строке в элементе под 0
int minRow = 0;
for (int i = 0; i < SumArray.Length; i++)
{
    if (minSum > SumArray[i])
    {
        minSum = SumArray[i];
        minRow = i;
    }
}
Console.WriteLine($"В строке {minRow} наименьшая сумма элементов");

