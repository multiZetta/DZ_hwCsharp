/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных 
чисел в массиве.

[345, 897, 568, 234] -> 2 */


/* Console.WriteLine("Ведите число размера массива. ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}
void PrintArray(int[] col)
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

int count = 0;
for (int i = 0; i < num; i++)
{
    if (array[i] % 2 == 0)
        count++;
}
Console.WriteLine("Количество четных чисел в массиве " + count + " шт."); */
