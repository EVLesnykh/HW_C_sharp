// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Задайте количество чисел M: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
  Console.Write($"Введите число {i + 1}: ");
  int num = Convert.ToInt32(Console.ReadLine());
  if (num > 0)
    count++;
}
Console.WriteLine($"Количество чисел > 0: {count}");