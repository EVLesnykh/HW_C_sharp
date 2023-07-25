// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int a = 1;
while (a <= x)
{
  if(a % 2 != 1)
  Console.WriteLine(a);
  a = a + 1;
}
