﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (99 >= a)
{
  Console.WriteLine($"У числа {a} нет третьей цифры");
}
else if (999 >= a)
{
  Console.WriteLine($"Третьей цифрой числа {a} является цифра: {a % 10}");
}
else if (99999 >= a)
{
 Console.WriteLine($"Третьей цифрой числа {a} является цифра: {a / 100 % 10}");
}