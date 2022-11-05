/* Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
//double

Console.WriteLine("Ведите число размера массива. ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите предельное число, до которого необходимо создать массив.");
int B = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];

void FillArray(double[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, B);
        index++;
    }
}
void PrintArray(double[] col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write($"{col[position]} {" "}");
        position++;
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();

double max = array[0];
for (int i = 0; i < num; i++)
{
    if (array[i] > max) max = array[i];
}


double min = array[0];
for (int i = 0; i < num; i++)
{
    if (array[i] < min) min = array[i];
}

double result = 0;
result = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементом массива составляет: " + result);