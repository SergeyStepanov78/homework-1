﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i < a)
{
    i += 1;
    if (i % 2 == 0) Console.Write(i + " ");
}