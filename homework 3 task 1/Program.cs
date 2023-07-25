﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();

if (num.Length == 5 && num[0] == num[4] && num[1] == num[3])
{
   Console.WriteLine($"Число {num} является палиндромом");
}
else if (num.Length == 5 && num[0] != num[4] && num[1] != num[3])
{
   Console.WriteLine($"Число {num} не является палиндромом");
}
else
{
    Console.WriteLine($"Число не пятизначное. Проверьте правильность ввода");
}