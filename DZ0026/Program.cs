/* Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите значение, для вывода всех его натуральных чисел по убыванию  ");
int num = Convert.ToInt32(Console.ReadLine());

int b = 1;

string NumbersRec(int num, int b)
{
    if (num <= b) return NumbersRec(num + 1, b) + $"{num} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(b, num));
