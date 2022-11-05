/* Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Ведите число размера массива. ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите предельное число, до которого необходимо создать массив.");
int B = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

void FillArray(int[] collection)
{
    int index = 0;
    while (index < collection.Length)
    {
        collection[index] = new Random().Next(1, B);
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

int result = 0;
for (int i = 0; i < num; i++)
{

    if (i % 2 == 1)
     result += array[i]++; 
}
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях составляет: " + result);


