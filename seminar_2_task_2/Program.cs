﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число, программа покажет третью цифру этого числа: ");
string number = Convert.ToString(int.Parse(Console.ReadLine()));
if (number.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + number[2]);
}
if (number.Length <= 2)
{
    Console.WriteLine("Во введенном числе отсутствует третья цифра");
}