// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без использования math.pow


Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

int res = 1;
{
for (int i = 0; i < B; i++)
    {
        res *= A;
    }
}
Console.Write(A + " в степени " + B + " = " + res);

