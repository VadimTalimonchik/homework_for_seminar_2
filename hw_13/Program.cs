﻿// Задача 13:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Введите число: ");
// int[] array = Console.ReadLine();
// int find = array[2];
// Console.WriteLine(find);

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
    int num = number % 10;
    Console.WriteLine($"Третья цифра числа: {num}");
}
