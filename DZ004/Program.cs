﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите любое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (99 < num && num < 999)
{
    num = num / 10 % 10;
    Console.WriteLine("Вторая цифра этого числа: " + num);
}
else
{
    Console.WriteLine("Число не соответсвует условиям задачи. Введите трехзначное число");
}


