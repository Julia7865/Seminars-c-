﻿// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbersFromNToOne(number);

void NaturalNumbersFromNToOne(int num)
{
    if (num < 1)
    {
        Console.Write($"{num} ");
        NaturalNumbersFromNToOne(num + 1);
    }
    if (num > 1)
    {
        Console.Write($"{num} ");
        NaturalNumbersFromNToOne(num - 1);

    }
    if (num == 1) Console.WriteLine($"{num}");
}























