/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


Console.Write("Сколько значений будете вводить?  ");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];

void FillArray(double[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write("Введите любое отрицательное или положительное число(цифру): ");
        array[i] = double.Parse(Console.ReadLine());
    }
}
FillArray(array);
Console.WriteLine();

int count = 0;
for (int i = 0; i < num; i++)
{
    if (array[i] > 0)
        count++;
}
Console.WriteLine("Количество чисел больше нуля " + count + " шт.");
