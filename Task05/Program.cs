﻿// Напишите программу, 
// которая на вход принимает одно число (N),
// а на выходе показывает все целые числа от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = -num;
while (counter <= num)
{
Console.Write($"{counter} ");
counter++;
}