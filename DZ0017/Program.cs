/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
                          a        b       d        c
                          5        2       9        4

значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.Write("Для нахождения точки пересечения двух прямых, заданных уравлениями y = a * x + b, y = d * x + c, введите следующие значения:");
Console.WriteLine();
Console.Write("a = ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("d = ");
double d = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
double c = Convert.ToInt32(Console.ReadLine());
double x = (-c + b) / (-a + d);
double y = d * x + c;
Console.WriteLine($"Две прямые пересекутся в точке с координатами ({x}; {y}).");