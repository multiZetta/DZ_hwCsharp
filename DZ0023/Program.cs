/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int row1 = 2;
int column1 = 2;
int row2 = 2;
int column2 = 2;


Console.WriteLine();

int[,] matrix = new int[row1, column2];
FillArray(matrix);
Console.WriteLine($"Первая матрица {row1}*{column1}");
PrintArray(matrix);

int[,] matr = new int[row2, column2];
FillArray(matr);
Console.WriteLine($"Вторая матрица {row2}*{column2}");
PrintArray(matr);

// Создали матрицы с рандомными числами

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

// Вывели в консоль матрицы с рандомными числами

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


// РЕШЕНИЕ   matrix * matr = matrixResult  Умножение матриц


if (matrix.GetLength(0) != matr.GetLength(1))
{
    Console.WriteLine("Размер строки одной матрицы не равен размеру столбца другой. Нельзя умножить");
    return;
}


int[,] matrixResult = new int[row1, column2];   // Создать новую результирующую матрицу
Console.WriteLine("Произведение двух матриц");


void Collection(int[,] matrix, int[,] matr, int[,] matrixResult)
{
    for (int i = 0; i < matrixResult.GetLength(0); i++)
    {
        for (int j = 0; j < matrixResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[i, k] * matr[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }
}
Collection(matrix, matr, matrixResult);  // Вызвали метод void Collection
PrintArray(matrixResult);               //  Вывели в консоль  matrixResult