// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sumdigits(int num)
{
  int sum = 0;
  int d = 0;
  while (num != 0)
  {
    d = num % 10; 
    sum = sum + d;
    num = num / 10;
  }
  return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в веденном числе: {Sumdigits(num)}");