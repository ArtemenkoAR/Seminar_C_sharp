//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число ");
double N = double.Parse(Console.ReadLine()!);
int i = 1;
Console.WriteLine("Последовательность четных чисел до " + N );
while (i < N)
    {
if (i % 2 == 0)
{
     Console.WriteLine (i);  
}
    i = i + 1;
    }