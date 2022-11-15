
/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
 */

Console.Write("Введите значение, от которого нужно начать отсчет  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение, до которого нужно посчитать сумму натуральных элементов в промежутке  ");
int b = Convert.ToInt32(Console.ReadLine());

int SumFor(int a, int b)
{
    int result = 0;
    for (int i = a; i <= b; i++) result += i;
    return result;
}
Console.WriteLine("Сумма натуральных элементов в промежутке от " + a + " до " + b + " составляет " + " " + SumFor(a, b));
