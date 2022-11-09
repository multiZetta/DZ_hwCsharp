/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */


Console.Write("Введите количество строк. ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов. ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            {
                Console.Write($"{new Random().NextDouble():f2} {" "}");
            }
        }
        Console.WriteLine();
    }
}
PrintArray(array);

