﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число N");
string str = Console.ReadLine();
int N = Convert.ToInt32(str);
int i = 2;
while (i <= N)
{
    Console.WriteLine(i + " ");
    i = i+2;
}



