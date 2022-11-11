/* Задача 29: Напишите программу, которая задаёт 
массив из N элементов и выводит их на экран.
N = 5, получаем массив [1, 2, 5, 7, 19]
N = 3, получаем массив [6, 1, 33] */

/* Console.WriteLine("Сколько элементов массива вам требуется? Введите число. ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите предельное число, до которого необходимо создать массив.");
int B = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Массив случайных чисел из " + num + " элементов, содержит следующие значения: ");

void FillArray(int[] collection)
{
    int num = collection.Length;
    int index = 0;
    while (index < num)
    {
        collection[index] = new Random().Next(1, B);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} {" "}");
        position++;
    }
}

int[] array = new int[num];

FillArray(array);
PrintArray(array); */


