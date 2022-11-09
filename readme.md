> ## __Практическая работа__

> ## Семинар №1


**Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.**
a = 5; b = 7 -> max = 7

a = 2 b = 10 -> max = 10

a = -9 b = -3 -> max = -3

Решение

[Блок схема](DZ_hwCsharp001/DZ_hwCsharp001.drawio.png) | [Код](DZ_hwCsharp001/Program.cs)

**Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.**

2, 3, 7 -> 7

44 5 78 -> 78

22 3 9 -> 22

Решение

[Блок схема](DZ_hwCsharp002/DZ_hwCsharp002.drawio.png) | [Код](DZ_hwCsharp002/Program.cs)

**Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).**

4 -> да

-3 -> нет

 7 -> нет

 Решение

[Блок схема](DZ_hwCsharp003/DZ_hwCsharp003.drawio.png) | [Код](DZ_hwCsharp003/Program.cs)

**Задача 8: Напишите программу, которая на вход принимает число (N),  а на выходе показывает все чётные числа от 1 до N.**

5 -> 2, 4

8 -> 2, 4, 6, 8

Решение

[Блок схема](Z_hwCsharp004/Z_hwCsharp004.drawio.png) | [Код](Z_hwCsharp004/Program.cs)


> ## Семинар №2

 **Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.**
 
456 -> 5

782 -> 8

918 -> 1

Решение

[Блок схема](DZ004/DZ004.drawio.png) | [Код](DZ004/Program.cs)

**Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.**

НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Решение

[Блок схема](DZ005/DZ005.drawio.png) | [Код](DZ005/Program.cs)

**Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.**

6 -> да

7 -> да

1 -> нет

Решение

[Блок схема](DZ006/DZ006.drawio.png) | [Код](DZ006/Program.cs)


> ## Семинар №3

**Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.**

14212 -> нет

12821 -> да

23432 -> да

Решение

[Блок схема](DZ007/DZ007.drawio.png) | [Код](DZ007/Program.cs)


**Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.**

3 -> 1, 8, 27

5 -> 1, 8, 27, 64, 125


Решение

[Блок схема](DZ008/DZ008.drawio.png) | [Код](DZ008/Program.cs)


> ## Семинар №4

**Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.**

3, 5 -> 243 (3⁵)

2, 4 -> 16

без использования math.pow

Решение

[Блок схема](DZ0010/DZ0010.drawio.png) | [Код](DZ0010/Program.cs)


**Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.**

N = 5, получаем массив [1, 2, 5, 7, 19]

N = 3, получаем массив [6, 1, 33]

Решение

[Блок схема](DZ0012/DZ0012.drawio.png) | [Код](DZ0012/Program.cs)

**Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.**

452 -> 11

82 -> 10

9012 -> 12

Решение

[Блок схема](DZ0011/DZ0011.drawio.png) | [Код](DZ0011/Program.cs)

> ## Семинар №5

**Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.**

[345, 897, 568, 234] -> 2 */

Решение

[Блок схема](DZ0013/DZ0013.drawio.png) | [Код](DZ0013/Program.cs)


**Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.**

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Решение

[Блок схема](DZ0014/DZ0014.drawio.png) | [Код](DZ0014/Program.cs)


**Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.**

[3 7 22 2 78] -> 76 */

Решение

[Блок схема](DZ0015/DZ0015.drawio.png) | [Код](DZ0015/Program.cs)

> ## Семинар №6

**Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.**

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

Решение

[Блок схема](DZ0016/DZ0016.drawio.png) | [Код](DZ0016/Program.cs)

**Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.**

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Решение

[Блок схема](DZ0017/DZ0017.drawio.png) | [Код](DZ0017/Program.cs)

> ## Семинар №7

**Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.**

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9

Решение

[Блок схема](DZ0018/DZ0018.drawio.png) | [Код](DZ0018/Program.cs)


**Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.**

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет

Решение

[Блок схема](DZ0019/DZ0019.drawio.png) | [Код](DZ0019/Program.cs)


**Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.**

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Решение

[Блок схема](DZ0020/DZ0020.drawio.png) | [Код](DZ0020/Program.cs)