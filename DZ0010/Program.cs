// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в целую степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без использования math.pow

double Pow(int a, int b)
{

    if (a == 0 && b == 0) return double.NaN;   
    bool flaq = b > 0;
    if (b < 0) b = -b;
    int res = 1;                      
    for (int i = 0; i < b; i++)
    {
        res *= a;                  
    }
    if (flaq) return res;    
    else return 1.0 / res;         
}
Console.WriteLine(Pow(5, -2));   
Console.WriteLine(Pow(5, 2));   
Console.WriteLine(Pow(0, 0));   

