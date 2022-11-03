// Задача 23
// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите цифру: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица кубов от 1 до " + N + ":  ");
for (int j = 1; j <= N; j++)
{
    Console.WriteLine($"{j} * {j} * {j} = {j * j * j}");
}
Console.WriteLine();
